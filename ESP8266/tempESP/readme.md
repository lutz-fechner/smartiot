# ESP8266 Web Temperature
A simple http REST service that returns the current tempature from a 1-wire DS18B20 sensor.
I've create this to integrate into WhatsUp Gold system monitoring software to monitor/alert on server room temperature.

## WIFI config
The ESP8266 obtains it's TCP/IP configuration via DHCP. For the WIFI connection details you need to set STASSID and STAPSK.

## URL
You need to call http://<< IP >>/temp to get the tempature back. Temperature is returned as decimal and integer.

## Sensor
This is the sensor I used: [Buy on Amazon](https://amzn.to/4b11ylo)