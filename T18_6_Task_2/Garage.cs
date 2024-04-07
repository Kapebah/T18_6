using System;
using System.Collections.Generic;
using static System.Console;

namespace T18_6_Task_2
{
    /// <summary>
    /// Class of constants identifying actions
    /// </summary>
    enum Action { AddBicycles = 1, AddCars, AddLorries, OutputBicycles, OutputCars, OutputLorries, Exit }
    /// <summary>
    /// Class - collection
    /// </summary>
    class Garage
    {
        /// <summary>
        /// Databases into which information is recorded
        /// </summary>
        List<Bicycle> bicycles = new List<Bicycle>();
        List<Car> cars = new List<Car>();
        List<Lorry> lorries = new List<Lorry>();
        /// <summary>
        /// Method for working with classes
        /// </summary>
        public void WorkWithVehicles()
        {
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine("Choose an action: ");
            ResetColor();
            WriteLine("\t\t1 - Add bicycle to list\n\t\t2 - Add car to list\n\t\t3 - Add lorry to list\n\t\t4 - Output all bicycles\n\t\t5 - Output all cars\n\t\t6 - Output all lorries\n\t\t7 - Exit\n");
            if (Enum.TryParse(ReadLine(), out Action action))
            {
                ///Action selection
                switch (action)
                {
                    case Action.AddBicycles:
                        Clear();
                        bicycles.Add(Bicycle.Input());
                        break;
                    case Action.AddCars:
                        Clear();
                        cars.Add(Car.Input());
                        break;
                    case Action.AddLorries:
                        Clear();
                        lorries.Add(Lorry.Input());
                        break;
                    case Action.OutputBicycles:
                        Clear();
                        ForegroundColor = ConsoleColor.DarkCyan;
                        WriteLine("All bicycles: \n");
                        ResetColor();
                        foreach (var bicycle in bicycles)
                        {
                            WriteLine(bicycle.ToString());
                            WriteLine();
                        }
                        break;
                    ///Information outputs
                    case Action.OutputCars:
                        Clear();
                        ForegroundColor = ConsoleColor.DarkCyan;
                        WriteLine("All cars: ");
                        ResetColor();
                        foreach (var car in cars)
                        {
                            WriteLine(car.ToString());
                            WriteLine();
                        }
                        break;
                    case Action.OutputLorries:
                        Clear();
                        ForegroundColor = ConsoleColor.DarkCyan;
                        WriteLine("All lorries: ");
                        ResetColor();
                        foreach (var lorry in lorries)
                        {
                            WriteLine(lorry.ToString());
                            WriteLine();
                        }
                        break;
                    ///Exiting the console
                    case Action.Exit:
                        Environment.Exit(0);
                        break;
                }
            }
            else { WriteLine("Wrong! Try again."); }
        }
    }
}
