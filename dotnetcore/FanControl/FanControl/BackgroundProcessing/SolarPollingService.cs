using FanControl.Data;
using FanControl.Model;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FanControl.BackgroundProcessing
{
    public class SolarPollingService : IHostedService, IDisposable
    {
        private int executionCount = 0;
        private readonly ILogger<SolarPollingService> _logger;
        private Timer _timer;

        private Dictionary<string, Inverter> inverters;

        private FanService fanService;

        public SolarPollingService(ILogger<SolarPollingService> logger, FanService fns)
        {
            _logger = logger;
            fanService = fns;
            inverters = new Dictionary<string, Inverter>();

            Inverter inv1 = new Inverter();
            inv1.InverterName = "3,6kW";
            inv1.InverterRestUrl = "https://test.com";

            Inverter inv2 = new Inverter();
            inv2.InverterName = "6,3kW";
            inv2.InverterRestUrl = "https://test2.com";


        }

        public Inverter GetInverter(string url, string name)
        {
            Inverter inv;

            if (inverters.ContainsKey(url))
            {
                inv = inverters[url];
            }
            else
            {
                Inverter newInv = new Inverter();
                newInv.InverterRestUrl = url;
                newInv.InverterName = name;

                inverters.Add(url, newInv);
                inv = newInv;
            }


            return inv;
        }

        public Task StartAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("SolarPollingService started.");

            _timer = new Timer(DoWork, null, TimeSpan.Zero,
                TimeSpan.FromSeconds(5));

            return Task.CompletedTask;
        }

        private void DoWork(object state)
        {
            var count = Interlocked.Increment(ref executionCount);

            _logger.LogInformation(
                "Timed Hosted Service is working. Count: {Count}", count);

            fanService.executionCounter = count;
            
        }

        public Task StopAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("SolarPollingService is stopping.");

            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
