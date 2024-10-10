using bofa_poc_di.Interface.DependencyInjectionConsoleApp;
using bofa_poc_di.Service.DependencyInjectionConsoleApp;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjectionConsoleApp
{
    class Program
    {
        /// <summary>
        /// Configuraion for service provider in steps.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Create a svc collection
            var serviceCollection = new ServiceCollection();

            ConfigureServices(serviceCollection);

            // Build
            var serviceProvider = serviceCollection.BuildServiceProvider();

            // Resolve and use the service
            var greetingService = serviceProvider.GetService<IGreetingService>();

            // Use the resolved service
            Console.Write("Enter your name:");
            string name = Console.ReadLine();
            greetingService?.Greet(name);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // Registering the GreetingService
            services.AddTransient<IGreetingService, GreetingService>();

            // Swapping demo
            // *Note* If u want to see swaping, commet this line
            //services.AddTransient<IGreetingService, GreetingServiceSwap>();
        }
    }
}