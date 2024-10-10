using bofa_poc_factory.Interface.FactoryMethodPatternApp;

namespace bofa_poc_factory.Factory.FactoryMethodPatternApp
{
    public class Vehicle : IVehicle
    {
        /// <summary>
        /// Different types of objects factory - tesla
        /// </summary>
        public void Drive()
        {
            Console.WriteLine("Driving a Tesla...");
        }
    }

    /// <summary>
    /// Different types of objects factory - motorcycle
    /// </summary>
    public class Motorcycle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Riding a motorcycle...");
        }
    }
}
