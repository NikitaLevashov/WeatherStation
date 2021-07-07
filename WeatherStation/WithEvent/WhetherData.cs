using System;

namespace WeatherStation.WithEvent
{
    public class WhetherData
    {
        public event EventHandler<WheatherInfoEventArgs> WheatherChange = delegate { };

        protected virtual void OnWheatherChange(object sender, WheatherInfoEventArgs eventArgs)
        {
            WheatherChange?.Invoke(this, eventArgs);
        }
        public void SimulateWheather(double temperature, double humidity, double pressure)
        {
            OnWheatherChange(this, new WheatherInfoEventArgs(temperature, humidity, pressure));
        }
    }
}
