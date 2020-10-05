using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanControl.Model
{
    public class Inverter
    {
        public string InverterName { get; set; }

        public string InverterRestUrl { get; set; }

        public int CurrentPower { get; set; }

        public int TodayHarvest { get; set; }
    }
}
