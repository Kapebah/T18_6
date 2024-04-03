using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T18_6_Task_2
{
    class Lorry : Vehicle
    {
        /// <summary>
        /// Maximum capacity of the lorry
        /// </summary>
        public int MaxCapacity { get; set; }
        /// <summary>
        /// Constructors
        /// </summary>
        public Lorry() { }
        public Lorry(double price, double maxSpeed, int vehicleYear, int maxCapacity) : base(price, maxSpeed, vehicleYear) =>  MaxCapacity = maxCapacity;
        /// <summary>
        /// Overriden method Tostring() for output info
        /// </summary>
        /// <returns>Output info about lorry</returns>
        public override string ToString()
        {
            return $"Price: {Price}\nMaximum speed: {MaxSpeed}\nYear of manufacturer of the car: {VehicleYear}\n" +
                $"Maximum capacity in tons: {MaxCapacity}";
        }
        public static Lorry Input()
        {
            Write("Enter the lorry's price: ");
            double price = Convert.ToDouble(ReadLine());
            Write("Enter the lorry's maximum speed in km/h: ");
            double maxSpeed = Convert.ToDouble(ReadLine());
            Write("Enter the lorry's year of manufacturer: ");
            int vehicleYear = Convert.ToInt32(ReadLine());
            Write("Enter lorry's max capacity in tons: ");
            int maxCapacity = Convert.ToInt32(ReadLine());
            return new Lorry(price, maxSpeed, vehicleYear, maxCapacity);
        }

    }
}
