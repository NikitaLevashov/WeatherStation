using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation.WithEvent
{
    public class CurrentConditionsReport
    {
        public CurrentConditionsReport(WhetherData data)
        {
            data.WheatherChange += WheatherMsg;
        }

        private void WheatherMsg(object sender, WheatherInfoEventArgs eventArgs)
        {
            Console.WriteLine("Temperature = {0}, Humidity = {1}, Pressure = {2}", eventArgs.Temperature, eventArgs.Pressure, eventArgs.Humidity);
        }

        public void Unregister(WhetherData mail)
        {
            mail.WheatherChange -= WheatherMsg;
        }
    }
}
