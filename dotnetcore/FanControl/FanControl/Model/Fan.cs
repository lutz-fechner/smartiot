using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanControl.Model
{
    public class Fan
    {
        public string Url { get; set; }

        public int CurrentValue{ get; set; }

        public string LastState { get; set; } = "unknown";

        public int MotorOneBrake { get; set; }

        public int FanFactor { get; set; }

        public int FanCount { get; set; }
    }
}
