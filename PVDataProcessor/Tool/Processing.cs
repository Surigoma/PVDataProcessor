using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}
