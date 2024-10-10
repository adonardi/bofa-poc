using bofa_poc_observation.Interface.ObserverPatternApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bofa_poc_observation.Concrete.ObserverPatternApp
{
    public class PhoneDisplay : IObserver
    {
        private string _name;

        public PhoneDisplay(string name)
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
