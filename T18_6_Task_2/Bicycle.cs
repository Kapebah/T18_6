using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T18_6_Task_2
{
    class Bicycle : Vehicle
    {
        /// <summary>
        /// Count of passengers
        /// </summary>
        public int CountOfPassengers { get; set; }
        /// <summary>
        /// Constructors
        /// </summary>
        public Bicycle() { }
        public Bicycle(double price, double maxSpeed, int vehicleYear, int countOfPassengers) : base(price, maxSpeed, vehicleYear) => CountOfPassengers = countOfPassengers;
        /// <summary>
        /// Overriden method ToString() for output info
        /// </summary>
        /// <returns>Output info about bicycles</returns>
        public override string ToString()
        {
            return $"Price: {Price}\nMaximum speed: {MaxSpeed}\nYear of manufacturer of the bicycle: {VehicleYear}\nCount of passengers: {CountOfPassengers}";
        }
    }
}
