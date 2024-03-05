using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T18_6_Task_2
{
    class Car : Vehicle
    {
        /// <summary>
        /// Car power in horsepower
        /// </summary>
        public double VehiclePower { get; set; }
        /// <summary>
        /// Constructros
        /// </summary>
        public Car() { }
        public Car(double price, double maxSpeed, int vehicleYear, double vehiclePower) : base(price, maxSpeed, vehicleYear) => VehiclePower = vehiclePower;
        /// <summary>
        /// Overriden method Tostring() for output info
        /// </summary>
        /// <returns>Output info about car</returns>
        public override string ToString()
        {
            return $"Price: {Price}\nMaximum speed: {MaxSpeed}\nYear of manufacturer of the car: {VehicleYear}\n" +
                $"Car power in horsepower: {VehiclePower}";
        }
    }
}
