using System;
using System.Collections.Generic;
using System.IO;

namespace PVDataProcessor.Tool
{
    class Processing
    {
        public double CalcIntegratedWatts(PH[] PHdata, int interval)
        {
            double result=0.0;
            for (int i = 0; i < PHdata.Length; i++)
            {
                result += (interval / 3600) * PHdata[i].Watts;
            }
            return result;
        }

        public void CutPerDay(List<SampleData> datas, string prefix, string filepath)
        {
            String filename;
            datas.Sort(CompareByDate);
            foreach (SampleData sd in datas)
            {
                filename = filepath+prefix.Replace("%d",sd.SamplingDate.ToShortDateString())+".csv";
                StreamWriter sw = new StreamWriter(filepath, true, System.Text.Encoding.GetEncoding("utf8"));
                sw.WriteLine("#");
                sw.WriteLine("Time,Watts PH1 PPA1,DC Voltage PH1 PPA1,DC Current PH1 PPA1,Integrated Watts PH1 PPA1,Watts PH2 PPA1,DC Voltage PH2 PPA1,DC Current PH2 PPA1,Watts PH3 PPA1,DC Voltage PH3 PPA1,DC Current PH3 PPA1,Watts PH1 PPA2,DC Voltage PH1 PPA2,DC Current PH1 PPA2,Integrated Watts PH1 PPA2,Watts PH2 PPA2,DC Voltage PH2 PPA2,DC Current PH2 PPA2,Watts PH3 PPA2,DC Voltage PH3 PPA2,DC Current PH3 PPA2,Watts PH1 PPA3,DC Voltage PH1 PPA3,DC Current PH1 PPA3,Integrated Watts PH1 PPA3,Watts PH2 PPA3,DC Voltage PH2 PPA3,DC Current PH2 PPA3,Watts PH3 PPA3,DC Voltage PH3 PPA3,DC Current PH3 PPA3");
                sw.Write(sd.SamplingDate.ToString()+",");
                foreach (PPA ppa in sd.Data)
                {
                    foreach (PH ph in ppa.PHData)
                    {
                        sw.Write(GetInfo(ph));
                        sw.Write(",");
                    }
                }
                sw.WriteLine();
                sw.Close();
            }
        }

        public int CompareByDate(SampleData a, SampleData b)
        {
            return DateTime.Compare(a.SamplingDate, b.SamplingDate);
        }

        public string GetInfo(PH ph)
        {
            String result;
            result = String.Format("%e,%e,%e,%e", ph.Watts, ph.Voltage, ph.Current, ph.IntegratedWatts);
            return result;
            
        }

    }
}
