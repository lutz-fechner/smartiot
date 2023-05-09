using FanControl.Data;
using FanControl.Model;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace FanControl.BackgroundProcessing
{
    public class SolarPollingService : IHostedService, IDisposable
    {
        private int executionCount = 0;
        private readonly ILogger<SolarPollingService> _logger;
        private Timer _timer;

        private Dictionary<string, Inverter> inverters;

        private FanService fanService;

        public MeterData CurrentMeterValues { get; set; }

        public SolarPollingService(ILogger<SolarPollingService> logger, FanService fns)
        {
            _logger = logger;
            fanService = fns;
            inverters = new Dictionary<string, Inverter>();

            Inverter inv1 = new Inverter();
            inv1.InverterName = "3,6kW Solar";
            inv1.InverterRestUrl = "https://www.solaxcloud.com/proxyApp/proxy/api/getRealtimeInfo.do?tokenId=20201001100554512936094&sn=SW5MAHMNZ6";
            inverters.Add(inv1.InverterName, inv1);

            Inverter inv2 = new Inverter();
            inv2.InverterName = "4,2kW Solar";
            inv2.InverterRestUrl = "https://www.solaxcloud.com/proxyApp/proxy/api/getRealtimeInfo.do?tokenId=20201001100554512936094&sn=SWXCNWU9YD";
            inverters.Add(inv2.InverterName, inv2);

            Inverter inv3 = new Inverter();
            inv3.InverterName = "5,0kW Solar";
            inv3.InverterRestUrl = "https://www.solaxcloud.com/proxyApp/proxy/api/getRealtimeInfo.do?tokenId=20201001100554512936094&sn=SW6VLTSXSF";
            inverters.Add(inv3.InverterName, inv3);

            Inverter inv4 = new Inverter();
            inv4.InverterName = "15,0kW Battery";
            inv4.InverterRestUrl = "https://www.solaxcloud.com/proxyApp/proxy/api/getRealtimeInfo.do?tokenId=20201001100554512936094&sn=SRVZRCUP7F";
            inv4.BatteryInverter = true;
            inverters.Add(inv4.InverterName, inv4);

            Inverter inv5 = new Inverter();
            inv5.InverterName = "4,6kW Solar (broken)";
            inv5.InverterRestUrl = "";
            inv5.Broken = true;
            inv5.TotalHarvest = 12780.3;
            inverters.Add(inv5.InverterName, inv5);

            CurrentMeterValues = new MeterData("http://192.168.178.3/addons/xmlapi/state.cgi?device_id=5663");
        }

        public Inverter[] Inverters()
        {
            return inverters.Values.ToArray();
        }

        public int CurrentCount()
        {
            return executionCount;
        }

        public Task StartAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("SolarPollingService started.");

            _timer = new Timer(DoWork, null, TimeSpan.Zero,
                TimeSpan.FromSeconds(300));

            return Task.CompletedTask;
        }

        private void DoWork(object state)
        {
            var count = Interlocked.Increment(ref executionCount);

            _logger.LogInformation("Timed Hosted Service is working. Count: {Count}", count);

            foreach(var inverter in inverters.Values)
            {
                if(!inverter.Broken)
                {
                    _logger.LogInformation("Reading values from " + inverter.InverterName);
                    updateInverterFromHttp(inverter);
                    System.Threading.Thread.Sleep(1000);                 
                }
            }

            updateMeterData();

            fanService.executionCounter = count;
            
        }

        private void updateMeterData()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(CurrentMeterValues.MeterURL);
            request.Timeout = 5000;

            WebResponse response = request.GetResponse();


            StreamReader streamReader = new StreamReader(response.GetResponseStream(), Encoding.Default);

            string xmlString = streamReader.ReadToEnd();

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlString);
            XmlNode importNode = doc.DocumentElement.SelectSingleNode("//state/device/channel[@name='Bezug']/datapoint[@type='IEC_ENERGY_COUNTER']");
            string importValueString = importNode.Attributes["value"].InnerText;
            XmlNode exportNode = doc.DocumentElement.SelectSingleNode("//state/device/channel[@name='Einspeisung']/datapoint[@type='IEC_ENERGY_COUNTER']");
            string exportValueString = exportNode.Attributes["value"].InnerText;

            CurrentMeterValues.ImportAmount = Convert.ToInt32(importValueString.Substring(0, importValueString.IndexOf(".")));
            CurrentMeterValues.ExportAmount = Convert.ToInt32(exportValueString.Substring(0, exportValueString.IndexOf(".")));

            streamReader.Close();
        }

        private void updateInverterFromHttp(Inverter inverter)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(inverter.InverterRestUrl);
            request.Timeout = 5000;

            WebResponse response = request.GetResponse();


            StreamReader streamReader = new StreamReader(response.GetResponseStream(), Encoding.Default);

            string json = streamReader.ReadToEnd();

            _logger.LogInformation(json);
            JObject jsonObject = JObject.Parse(json);

            if ((bool)jsonObject["success"] == true)
            {
                inverter.CurrentPower = (double)jsonObject["result"]["acpower"];
                inverter.TodayHarvest = (double)jsonObject["result"]["yieldtoday"];
                inverter.TotalHarvest = (double)jsonObject["result"]["yieldtotal"];

                JObject result = (JObject)jsonObject["result"];

                JValue temp = (JValue)jsonObject["result"]["soc"];

                if (temp.Value != null)
                {
                    inverter.StateOfCharge = (int)jsonObject["result"]["soc"];
                }
            }

            streamReader.Close();
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
