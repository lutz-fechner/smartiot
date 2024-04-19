using FanControl.BackgroundProcessing;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace FanControl.Model
{
    public class Inverter
    {
        public string InverterName { get; set; }

        public string InverterRestUrl { get; set; }

        public double CurrentPower { get; set; }

        public double TodayHarvest { get; set; }

        public double TotalHarvest { get; set; }

        public bool BatteryInverter { get; set; }

        public bool Broken { get; set; }

        public int StateOfCharge { get; set; }
    }
}
