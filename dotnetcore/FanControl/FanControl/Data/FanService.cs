using FanControl.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace FanControl.Data
{
    public class FanService
    {
        private Dictionary<string, Fan> fans;

        public int executionCounter { get; set; }

        public string lastUrl { get; set; }

        public FanService()
        {
            fans = new Dictionary<string, Fan>();
        }

        public Fan GetFanByUrl(string url)
        {
            Fan fan;

            if (fans.ContainsKey(url))
            {
                fan = fans[url];
            }
            else
            {
                Fan newFan = new Fan();
                newFan.CurrentValue = 0;
                newFan.Url = url;

                fans.Add(url, newFan);
                fan = newFan;
            }


            return fan;
        }


        public void Increment(string forUrl)
        {
            Fan fan = this.GetFanByUrl(forUrl);

            fan.CurrentValue += 1;

            if(fan.CurrentValue > 100)
            {
                fan.CurrentValue = 100;
            }

            lastUrl = forUrl;

            updateIotDevice(fan);
        }

        public void Decrement(string forUrl)
        {
            Fan fan = this.GetFanByUrl(forUrl);

            fan.CurrentValue -= 1;

            if (fan.CurrentValue < 0)
            {
                fan.CurrentValue = 0;
            }

            lastUrl = forUrl;

            updateIotDevice(fan);
        }

        public void SetToSpeed(string forUrl, int newSpeed)
        {
            Fan fan = this.GetFanByUrl(forUrl);

            fan.CurrentValue = newSpeed;

            lastUrl = forUrl;

            updateIotDevice(fan);
        }

        public int getCurrentValueForUrl(string forUrl)
        {
            return this.GetFanByUrl(forUrl).CurrentValue;
        }

        public string getLastState(string forUrl)
        {
            return this.GetFanByUrl(forUrl).LastState;
        }

        private void updateIotDevice(Fan fan)
        {
            int lueftung = fan.CurrentValue;

            int motorWert1 = lueftung * fan.FanFactor;
            if (motorWert1 > 999)
            {
                motorWert1 = 1023;
            }

            int motorWert2 = motorWert1;

            motorWert1 = motorWert1 - fan.MotorOneBrake;
            if (motorWert1 < 0)
            {
                motorWert1 = 0;
            }

            try
            { 
                string urlMotor1 = fan.Url + "/fan1?speed=" + motorWert1;
                HttpWebRequest motorRequest1 =(HttpWebRequest)WebRequest.Create(urlMotor1);
                motorRequest1.Timeout = 5000;

                motorRequest1.GetResponse();

                if(fan.FanCount == 4)
                {
                    string urlMotor3 = fan.Url + "/fan3?speed=" + motorWert1;
                    HttpWebRequest motorRequest3 = (HttpWebRequest)WebRequest.Create(urlMotor3);
                    motorRequest3.Timeout = 5000;
                    
                    motorRequest3.GetResponse();
                }

                string urlMotor2 = fan.Url + "/fan2?speed=" + motorWert2;
                HttpWebRequest motorRequest2 = (HttpWebRequest)WebRequest.Create(urlMotor2);
                motorRequest2.Timeout = 5000;
                motorRequest2.GetResponse();

                if (fan.FanCount == 4)
                {
                    string urlMotor4 = fan.Url + "/fan4?speed=" + motorWert2;
                    HttpWebRequest motorRequest4 = (HttpWebRequest)WebRequest.Create(urlMotor4);
                    motorRequest4.Timeout = 5000;

                    motorRequest4.GetResponse();
                }

                fan.LastState = "OK";
            }
            catch(Exception ex)
            {
                fan.LastState = "Failed to update ("+ex.Message+")";
            }


        }


    }
}
