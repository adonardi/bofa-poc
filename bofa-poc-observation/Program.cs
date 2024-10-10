using bofa_poc_observation.Concrete.ObserverPatternApp;
using System;

namespace ObserverPatternApp
{
    class Program
    {
        /// <summary>
        /// Create instance of weatherstation and observer
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            WeatherStation weatherStation = new WeatherStation();

            // Oobserver objects
            PhoneDisplay phoneDisplay1 = new PhoneDisplay("Phone Display 1");
            PhoneDisplay phoneDisplay2 = new PhoneDisplay("Phone Display 2");
            ComputerDisplay computerDisplay1 = new ComputerDisplay("Computer Display 1");

            // Attach
            weatherStation.Attach(phoneDisplay1);
            weatherStation.Attach(phoneDisplay2);
            weatherStation.Attach(computerDisplay1);

            Console.WriteLine("Updating weather state to Sunny...");
            // Update the state of the subject, which notifies observers
            weatherStation.WeatherState = "Sunny";

            Console.WriteLine("\nUpdating weather state to Rainy...");
            // Update again to show notify
            weatherStation.WeatherState = "Rainy";

            // Detach one observer and update the state again
            Console.WriteLine("\nDetaching Phone Display 2...");
            weatherStation.Detach(phoneDisplay2);

            Console.WriteLine("\nUpdating weather state to Cloudy...");
            weatherStation.WeatherState = "Cloudy";

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
