using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bofa_poc_singleton.SingletonPatternApp
{
    /// <summary>
    /// Singleton class to manage configuration settings
    /// </summary>
    public class ConfigurationManager
    {
        private static ConfigurationManager _instance;
        private ConfigurationManager()
        {
            Console.WriteLine("Configuration initialized.");
        }

        // Global access point
        public static ConfigurationManager GetInstance()
        {
            // Check if the instance is null
            if (_instance == null)
            {
                _instance = new ConfigurationManager();
            }

            return _instance;
        }

        // Just a sample, bro!!
        public void DisplayConfiguration()
        {
            Console.WriteLine("Displaying configuration settings...");
        }
    }
}
