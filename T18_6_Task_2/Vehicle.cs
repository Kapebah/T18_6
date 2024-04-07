using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T18_6_Task_2
{
    abstract class Vehicle
    {
        /// <summary>
        /// Price of vehicle
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Maximum speed of vehicle
        /// </summary>
        public double MaxSpeed { get; set; }
        /// <summary>
        /// Year of manufacturer of the vehicle
        /// </summary>
        public int VehicleYear { get; set; }
        /// <summary>
        /// Constructors
        /// </summary>
        public Vehicle() { }
        public Vehicle(double price, double maxSpeed, int vehicleYear)
        {
            Price = price; MaxSpeed = maxSpeed; VehicleYear = vehicleYear;
        }
        /// <summary>
        /// Output info about vehicle
        /// </summary>
        /// <returns>Info</returns>
        public new abstract string ToString();
    }
}
