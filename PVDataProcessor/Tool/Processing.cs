using System;
using System.Collections.Generic;
using System.IO;

namespace PVDataProcessor.Tool
{
    static class Processing
    {
        static public double CalcIntegratedWatts(PH[] PHdata, int interval)
        {
            double result = 0.0;
            for (int i = 0; i < PHdata.Length; i++)
            {
                result += (interval / 3600) * PHdata[i].Watts;
            }
            return result;
        }

        static public void CutPerDay(List<SampleData> datas, string prefix, string filepath)
        {
            if (filepath.Substring(filepath.Length - 1, 1) != @"\") { filepath += @"\"; }
            String filename;
            datas.Sort(CompareByDate);
            List<SampleData> DayData = new List<SampleData>();
            int Count = 0;
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
                    filename = filepath + prefix.Replace("%d", DayData[0].SamplingDate.ToString("yyyy-MM-dd")) + ".csv";
                    SaveSampleData(DayData, filename);
                }
            }
        }
        static public void SaveSampleData(List<SampleData> datas, string filename)
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
        static public int CompareByDate(SampleData a, SampleData b)
        {
            return DateTime.Compare(a.SamplingDate, b.SamplingDate);
        }

        static public string GetInfo(PH ph)
        {
            String result;
            result = String.Format("{0:e},{1:e},{2:e},{3:e}", ph.Watts, ph.Voltage, ph.Current, ph.IntegratedWatts);
            return result;

        }

        static public void ValidDataIndex(string Source, string Output, int Threshold)
        {
            Threshold = Math.Abs(Threshold) * -1;
            DB db = new DB();
            string[] files = Directory.GetFiles(Source);
            if (Output.Substring(Output.Length - 1, 1) != @"\") { Output += @"\"; }
            foreach (var f in files)
            {
                db.LoadDay(f);
                db.Datas.Sort(Processing.CompareByDate);
                double[] result = new double[db.Datas.Count];
                int Count = 0;
                foreach (var i in db.Datas)
                {
                    result[Count] = i.Data[0].PHData[0].Watts;
                    Count++;
                }
                result = MovingAverage(result, 100);
                result = Differential(result);
                result = Multiplication(result, 100);
                result = MovingAverage(result, 100);
                int ii = 0;
                for (ii = 0; ii < db.Datas.Count; ii++)
                    if (result[ii] < Threshold)
                    {
                        ii -= 120;
                        break;
                    }
                List<SampleData> savedata = db.Datas.GetRange(0, ii);
                SaveSampleData(savedata, Output + Path.GetFileName(f));
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
        }
        static public double[] Multiplication(double[] data, double x)
        {
            double[] result = new double[data.LongLength];
            for (int i = 0; i < data.Length; i++)
                result[i] = data[i] * x;
            return result;
        }
    }
}
