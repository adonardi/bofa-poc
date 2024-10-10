using bofa_poc_singleton.SingletonPatternApp;
using System;

namespace SingletonPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // create two instances of the ConfigurationManager class
            Console.WriteLine("ConfigurationManager instance 1...");
            ConfigurationManager configManager1 = ConfigurationManager.GetInstance();
            configManager1.DisplayConfiguration();

            Console.WriteLine("ConfigurationManager instance 2...");
            ConfigurationManager configManager2 = ConfigurationManager.GetInstance();
            configManager2.DisplayConfiguration();

            // Compare references the instance
            if (configManager1 == configManager2)
                Console.WriteLine("Both instances are the same.");
            else
                Console.WriteLine("Instances are different, which violates the Singleton pattern. Call SWAT lol....");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}