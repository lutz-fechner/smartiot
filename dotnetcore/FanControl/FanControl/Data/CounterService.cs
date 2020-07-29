using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanControl.Data
{
    public class CounterService
    {
        public int Count { get; private set; }
        public void Increment()
        {
            Count += 1;
        }
    }
}
