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
        /// <summary>
        /// Input info about car
        /// </summary>
        /// <returns>Inputed info</returns>
        public static Car Input()
        {
            Write("Enter the car's price: ");
            double price = Convert.ToDouble(ReadLine());
            Write("Enter the car's maximum speed in km/h: ");
            double maxSpeed = Convert.ToDouble(ReadLine());
            Write("Enter the care's year of manufacturer: ");
            int vehicleYear = Convert.ToInt32(ReadLine());
            Write("Enter car power in horsepower: ");
            int horsePower = Convert.ToInt32(ReadLine());
            return new Car(price, maxSpeed, vehicleYear, horsePower);
        }
    }
}
