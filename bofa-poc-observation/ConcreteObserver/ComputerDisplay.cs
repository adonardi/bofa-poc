using bofa_poc_observation.Interface.ObserverPatternApp;
using System;

namespace bofa_poc_observation.Concrete.ObserverPatternApp
{
    public class ComputerDisplay : IObserver
    {
        private string _name;

        public ComputerDisplay(string name)
        {
            _name = name;
        }

        // Update method that is called when the subject's state changes
        public void Update(string state)
        {
            Console.WriteLine($"{_name} received update: Weather is now {state}");
        }
    }
}
