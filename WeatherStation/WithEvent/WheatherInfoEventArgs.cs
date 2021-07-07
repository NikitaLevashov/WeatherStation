using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation.WithEvent
{
    public class WheatherInfoEventArgs : EventArgs
    {
		private double temperature;
		private double humidity;
		private double pressure;

		public WheatherInfoEventArgs(double temp, double hum, double pres)
		{
			temperature = temp;
			humidity = hum;
			pressure = pres;
		}
		public double Temperature { get { return temperature; } }
		public double Humidity { get { return humidity; } }
		public double Pressure { get { return pressure; } }
	}
}
