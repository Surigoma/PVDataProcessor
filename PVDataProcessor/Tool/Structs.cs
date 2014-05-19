using System;

namespace PVDataProcessor.Tool
{
    public class SampleData
    {
        public DateTime SamplingDate;
        public PPA[] Data;
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
        public double IntegratedWatts;  //積算電力
    }
}
