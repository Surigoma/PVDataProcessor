using System;
using System.Collections.Generic;

namespace PVDataProcessor.Tool
{
    public class DateLog
    {
        public List<SampleData> datas;
        public DateTime day;

        public double GetIntegratedWatts(int ppanum, int phnum)
        {
            List<PH> ph = new List<PH>();
            foreach (var i in this.datas)
            {
                ph.Add(i.Data[ppanum].PHData[phnum]);
            }
            return Processing.CalcIntegratedWatts(ph, 10);
        }
    }


    public class SampleData
    {
        public DateTime SamplingDate;
        public PPA[] Data;
        public bool valid;
    }

    public class PPA
    {
        public PH[] PHData;
    }

    public class PH
    {
        public double Voltage;          //電圧
        public double Current;          //電流
        public double Watts;            //電力
        //public double IntegratedWatts;  //積算電力
    }
}
