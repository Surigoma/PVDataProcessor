using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        public double Voltage;
        public double Current;
        public double Watts;
        public double IntegratedWatts;
    }
}
