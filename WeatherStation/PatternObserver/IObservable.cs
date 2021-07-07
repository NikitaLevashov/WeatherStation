using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation.PatternObserver
{
    /// <summary>
    /// Interface IObservable
    /// </summary>
    public interface IObservable
    {
        void Register(IObserver o);
        void Unregister(IObserver o);
        void Notify();
    }
}
