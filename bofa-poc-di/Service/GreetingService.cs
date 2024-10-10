using bofa_poc_di.Interface.DependencyInjectionConsoleApp;
using System;

namespace bofa_poc_di.Service.DependencyInjectionConsoleApp
{
    public class GreetingService : IGreetingService
    {
        /// <summary>
        /// Service implementtion.
        /// </summary>
        public void Greet(string name)
        {
            Console.WriteLine($"Hey, {name}! Welcome to DI test for BOFA. Enjoy.");
        }
    }

    /// <summary>
    /// Service implementtion for SWAP action.
    /// </summary>
    public class GreetingServiceSwap : IGreetingService
    {
        public void Greet(string name)
        {
            Console.WriteLine($"Hey, {name}. It is a swap demo.");
        }
    }
}
