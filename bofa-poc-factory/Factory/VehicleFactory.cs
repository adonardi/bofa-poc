using bofa_poc_factory.Factory.FactoryMethodPatternApp;
using bofa_poc_factory.Interface.FactoryMethodPatternApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace bofa_poc_factory.Factory
{
    // Types of vehicles
    public enum VehicleType
    {
        Tesla,
        Motorcycle
    }
    public class VehicleFactory
    {
        /// <summary>
        /// Factory method that creates instances based on vehicle type
        /// </summary>
        /// <param name="vehicleType">enum</param>
        /// <returns>object</returns>
        /// <exception cref="ArgumentException">message</exception>
        public IVehicle CreateVehicle(VehicleType vehicleType)
        {
            switch (vehicleType)
            {
                case VehicleType.Tesla:
                    return new Vehicle();
                case VehicleType.Motorcycle:
                    return new Motorcycle();
                default:
                    throw new ArgumentException("Ops! Invalid Vehicle type");
            }
        }
    }
}
