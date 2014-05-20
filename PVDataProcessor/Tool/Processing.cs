﻿using System;
using System.Collections.Generic;
using System.IO;

namespace PVDataProcessor.Tool
{
    static class Processing
    {
        static double nullData = -90000;
        static public ProcessPrev pp;

        public static double CalcIntegratedWatts(List<PH> PHdata, int interval)
        {
            double result = 0.0;
            foreach (PH data in PHdata)
            {
                result += (interval / 3600) * data.Watts;
            }
            return result;
        }

        public Dictionary<DateTime,DateLog> CutPerDay(List<SampleData> datas)
        {
            Dictionary<DateTime, DateLog> result = new Dictionary<DateTime, DateLog>();
            DateLog value = new DateLog();
            DateTime key = new DateTime();

            bool flag = false;
            if (pp == null)
            {
                flag = true;
                pp = new ProcessPrev();
                pp.Show();
                pp.SetTitle("Valid data Cutting start.");
            }

            datas.Sort(CompareByDate);
            List<SampleData> DayData = new List<SampleData>();
            int Count = 0;
            pp.SetMaxProgress(datas.Count);
            if (flag)
                pp.SetMaxAllProgress(datas.Count);
            while (datas.Count > Count + 1)
            {
                DayData.Clear();
                int h = 0;
                while (datas[Count].SamplingDate.Hour - h >= 0 && datas.Count > Count + 1)
                {
                    DayData.Add(datas[Count]);
                    h = datas[Count].SamplingDate.Hour;
                    Count++;
                }
                if (DayData.Count > 0)
                {
                    pp.SetTitle("Day Cutting : " + DayData[0].SamplingDate.ToShortDateString());
                    key = DayData[0].SamplingDate;
                    value.datas = DayData;
                    result.Add(key, value);
                }
                pp.UpdateProgress(Count);
                if (flag)
                    pp.UpdateAllProgress(Count);
            }
            pp.SetTitle("Valid data Cutting inish.");
            if (flag)
            {
                pp.Close();
                pp.Dispose();
                pp = null;
            }
            return result;
        }

        public void SaveSampleData(List<SampleData> datas, string filename)
        {
            StreamWriter sw = new StreamWriter(filename, false, System.Text.Encoding.UTF8);
            sw.WriteLine("#");
            sw.WriteLine("Time,Watts PH1 PPA1,DC Voltage PH1 PPA1,DC Current PH1 PPA1,Integrated Watts PH1 PPA1,Watts PH2 PPA1,DC Voltage PH2 PPA1,DC Current PH2 PPA1,Integrated Watts PH2 PPA1,Watts PH3 PPA1,DC Voltage PH3 PPA1,DC Current PH3 PPA1,Integrated Watts PH3 PPA1,Watts PH1 PPA2,DC Voltage PH1 PPA2,DC Current PH1 PPA2,Integrated Watts PH1 PPA2,Watts PH2 PPA2,DC Voltage PH2 PPA2,DC Current PH2 PPA2,Integrated Watts PH2 PPA2,Watts PH3 PPA2,DC Voltage PH3 PPA2,DC Current PH3 PPA2,Integrated Watts PH3 PPA2,Watts PH1 PPA3,DC Voltage PH1 PPA3,DC Current PH1 PPA3,Integrated Watts PH1 PPA3,Watts PH2 PPA3,DC Voltage PH2 PPA3,DC Current PH2 PPA3,Integrated Watts PH2 PPA3,Watts PH3 PPA3,DC Voltage PH3 PPA3,DC Current PH3 PPA3,Integrated Watts PH3 PPA3");
            foreach (SampleData sd in datas)
            {
                sw.Write(sd.SamplingDate.ToString() + ",");
                foreach (PPA ppa in sd.Data)
                {
                    foreach (PH ph in ppa.PHData)
                    {
                        sw.Write(GetInfo(ph));
                        sw.Write(",");
                    }
                }
                sw.WriteLine();
            }
            sw.Close();
        }
        public int CompareByDate(SampleData a, SampleData b)
        {
            return DateTime.Compare(a.SamplingDate, b.SamplingDate);
        }

        public string GetInfo(PH ph)
        {
            String result;
            result = "" + (ph.Watts == nullData ? "" : ph.Watts.ToString("e")) + "," + (ph.Voltage == nullData ? "" : ph.Voltage.ToString("e")) + "," + (ph.Current == nullData ? "" : ph.Current.ToString("e")) + "," + (ph.IntegratedWatts == nullData ? "" : ph.IntegratedWatts.ToString("e"));
            //result = String.Format("{0:e},{1:e},{2:e},{3:e}", ph.Watts == nullData ? 0 : ph.Watts, ph.Voltage == nullData ? 0 : ph.Voltage, ph.Current == nullData ? 0 : ph.Current, ph.IntegratedWatts == nullData ? 0 : ph.IntegratedWatts);
            return result;
        }

        static public void ValidDataIndex(string Source, string Output, double Threshold)
        {
            bool flag = false;
            int lc = 0;
            if (pp == null)
            {
                flag = true;
                pp = new ProcessPrev();
                pp.Show();
                pp.SetTitle("Valid data Cutting start.");
            }
            DB db = new DB();
            string[] files = Directory.GetFiles(Source);
            if (Output.Substring(Output.Length - 1, 1) != @"\") { Output += @"\"; }
            pp.SetMaxProgress(files.Length);
            if (flag)
                pp.SetMaxAllProgress(files.Length);
            foreach (var f in files)
            {
                int Max = 0;
                db.LoadDay(f);
                pp.SetTitle("File Load : " + f);
                db.Datas.Sort(Processing.CompareByDate);
                for (int PPAi = 0; PPAi < 3; PPAi++)
                {
                    for (int PHi = 0; PHi < 3; PHi++)
                    {
                        pp.SetTitle(Path.GetFileName(f) + " - PPA" + PPAi.ToString() + " PH" + PHi.ToString());
                        double[] result = new double[db.Datas.Count];
                        int Count = 0;
                        foreach (var i in db.Datas)
                        {
                            result[Count] = i.Data[PPAi].PHData[PHi].Watts;
                            Count++;
                        }
                        double m = 0, mm = 0;
                        foreach (var i in result)
                            m = (m < i ? i : m);
                        result = MovingAverage(result, 100);
                        result = Differential(result);
                        result = Multiplication(result, 200);
                        result = MovingAverage(result, 100);
                        foreach (var i in result)
                            mm = (mm > i ? i : mm);
                        Console.WriteLine("" + m + " , " + mm + "," + mm / m);
                        int mi = 0;
                        for (int ii = 0; ii < db.Datas.Count; ii++)
                            if (result[ii] < Math.Abs(m * (Threshold / 100)) * -1)
                            {
                                mi = ii - 100;
                                break;
                            }
                        if (mi < 0) mi = 0;
                        for (int i = mi; i < db.Datas.Count; i++)
                        {
                            db.Datas[i].Data[PPAi].PHData[PHi].Watts = nullData;
                            db.Datas[i].Data[PPAi].PHData[PHi].Voltage = nullData;
                            db.Datas[i].Data[PPAi].PHData[PHi].Current = nullData;
                            db.Datas[i].Data[PPAi].PHData[PHi].IntegratedWatts = nullData;
                        }
                        if (mi > Max) { Max = mi; }
                    }
                }
                pp.SetTitle(Path.GetFileName(f) + " is Saving.");
                List<SampleData> savedata = db.Datas.GetRange(0, Max);
                SaveSampleData(savedata, Output + Path.GetFileName(f));
                pp.SetTitle(Path.GetFileName(f) + " is Saved.");
                lc++;
                pp.UpdateProgress(lc);
                if (flag)
                    pp.UpdateAllProgress(lc);
            }
            pp.SetTitle("Valid data Cutting inish.");
            if (flag)
            {
                pp.Close();
                pp.Dispose();
                pp = null;
            }
            return;
        }
        static public double[] MovingAverage(double[] data, int def)
        {
            double[] result = new double[data.LongLength], buff = new double[def];
            for (int i = 0; i < def; i++) { result[i] = 0; }
            for (int i = def; i < data.LongLength - 1; i++)
            {
                Array.Copy(data, i - def, buff, 0, def);
                result[i] = Average(buff);
            }
            return result;
        }
        static public double Average(double[] data)
        {
            double result = 0;
            foreach (var i in data) { result += i; }
            return result / data.LongLength;
        }

        static public double[] Differential(double[] data)
        {
            double[] result = new double[data.LongLength];
            result[0] = 0;
            for (int i = 1; i < data.LongLength; i++)
            {
                result[i] = data[i] - data[i - 1];
            }
            return result;
        }               //微分

        static public double[] Multiplication(double[] data, double x)      //乗
        {
            double[] result = new double[data.LongLength];
            for (int i = 0; i < data.Length; i++)
                result[i] = data[i] * x;
            return result;
        }

    }
}
