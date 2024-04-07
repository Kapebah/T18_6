using System;
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
        /// <summary>
        /// Input info about bicycle
        /// </summary>
        /// <returns>Inputed info</returns>
        public static Bicycle Input()
        {
            Write("Enter the bicycle's price: ");
            double price = Convert.ToDouble(ReadLine());
            Write("Enter the bicycle's maximum speed in km/h: ");
            double maxSpeed = Convert.ToDouble(ReadLine());
            Write("Enter the bycicle's year of manufacturer: ");
            int vehicleYear = Convert.ToInt32(ReadLine());
            Write("Enter count of passengers: ");
            int countOfPassengers = Convert.ToInt32(ReadLine());
            return new Bicycle(price, maxSpeed, vehicleYear, countOfPassengers);
        }

    }
}
