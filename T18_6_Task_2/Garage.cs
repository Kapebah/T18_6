using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T18_6_Task_2
{
    enum TypeOfVehicle { Bicycle = 1, Car, Lorry, Exit }
    class Garage
    {
        List<Vehicle> vehicles = new List<Vehicle>();

        public void AddVehicle()
        {
            if (Enum.TryParse(ReadLine(), out TypeOfVehicle vehicle))
            {
                switch (vehicle)
                {
                    case TypeOfVehicle.Bicycle:
                        vehicles.Add(Bicycle.Input());
                        break;
                    case TypeOfVehicle.Car:
                        vehicles.Add(Car.Input());
                        break;
                    case TypeOfVehicle.Lorry:
                        vehicles.Add(Lorry.Input());
                        break;
                    case TypeOfVehicle.Exit:
                        Environment.Exit(0);
                        break;
                }
            }
            else { WriteLine("Wrong! Try again."); }
        }

        public void OutputVehicle()
        {
            foreach(var vehicle in vehicles)
            {
                WriteLine(vehicle.ToString());
                WriteLine();
            }
        }

    }
}
