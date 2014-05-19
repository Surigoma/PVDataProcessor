using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PVDataProcessor.Tool
{
    public class DB
    {
        public List<SampleData> Datas = new List<SampleData>();
        public void Load(DateTime StartDate, string FilePath)
        {
            StreamReader sr = new StreamReader(FilePath);
            string i = "";
            string[] buff;
            bool First = false;
            List<string> ListPath = new List<string>();
            DateTime SelectDate = StartDate;
            int h = 0;
            while ((i = sr.ReadLine()) != null)
            {
                if (First)
                {
                    First = false;
                    ListPath.Clear();
                    buff = i.Split(',');
                    ListPath.AddRange(buff);
                }
                else if (i.IndexOf('#') != -1)
                {
                    First = true;
                }
                else
                {
                    buff = i.Split(',');
                    SampleData sd = new SampleData();
                    sd.Data = new PPA[3];
                    sd.Data[0] = new PPA();
                    sd.Data[1] = new PPA();
                    sd.Data[2] = new PPA();
                    sd.Data[0].PHData = new PH[3];
                    sd.Data[1].PHData = new PH[3];
                    sd.Data[2].PHData = new PH[3];
                    for (int ii = 0; ii < 3; ii++)
                    {
                        sd.Data[0].PHData[ii] = new PH();
                        sd.Data[1].PHData[ii] = new PH();
                        sd.Data[2].PHData[ii] = new PH();
                    }
                    for (int ii = 0; ii < buff.LongLength; ii++)
                    {
                        string[] c = ListPath[ii].Split(' ');
                        int PH = 0, PPA = 0, B = 0;
                        if (c.LongLength > 1)
                        {
                            if (c[1].IndexOf("PH") == -1)
                                B = 1;
                            PH = int.Parse(c[1 + B].Substring(2, 1)) - 1;
                            PPA = int.Parse(c[2 + B].Substring(3, 1)) - 1;
                        }
                        switch (c[0])
                        {
                            case "Time":
                                sd.SamplingDate = DateTime.ParseExact(SelectDate.ToString(@"yyyy/MM/dd") + " " + buff[ii], @"yyyy/MM/dd HH:mm:ss.FFF", null);
                                break;
                            case "Watts":
                                sd.Data[PPA].PHData[PH].Watts = double.Parse(buff[ii]);
                                break;
                            case "DC":
                                if (c[1] == "Voltage")
                                    sd.Data[PPA].PHData[PH].Voltage = double.Parse(buff[ii]);
                                else if (c[1] == "Current")
                                    sd.Data[PPA].PHData[PH].Current = double.Parse(buff[ii]);
                                break;
                            case "Integrated":
                                sd.Data[PPA].PHData[PH].IntegratedWatts = double.Parse(buff[ii]);
                                break;
                            default:
                                break;
                        }
                        if (sd.SamplingDate.Hour - h < 0)
                        {
                            SelectDate.AddDays(1);
                        }
                        h = sd.SamplingDate.Hour;
                    }
                    Datas.Add(sd);
                }
            }
            sr.Close();
        }
    }
}
