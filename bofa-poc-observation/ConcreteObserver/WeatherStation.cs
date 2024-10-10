using bofa_poc_observation.Interface.ObserverPatternApp;
using System;
using System.Collections.Generic;

namespace bofa_poc_observation.Concrete.ObserverPatternApp
{
    /// <summary>
    /// Observer and notify when state changes.
    /// </summary>
    public class WeatherStation : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        private string _weatherState;

        // State of the subject
        public string WeatherState
        {
            get { return _weatherState; }
            set
            {
                _weatherState = value;
                Notify();  // Notify observers when the state changes
            }
        }

        // Attach an observer to the subject
        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
            Console.WriteLine("Observer attached.");
        }

        // Detach an observer from the subject
        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine("Observer detached.");
        }

        // Notify all observers of a state change
        public void Notify()
        {
            Console.WriteLine("WeatherStation: Notifying observers...");
            foreach (var observer in _observers)
            {
                // async - for async, change void to asyc void.
                // await Task.Run(() => observer.Update(_weatherState));

                // sync
                observer.Update(_weatherState);
            }
        }
    }
}
