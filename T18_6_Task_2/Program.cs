using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T18_6_Task_2
{
    internal class Program
    {
        enum Action { AddBicycles = 1, AddCars, AddLorries, OutputBicycles, OutputCars, OutputLorries, Exit }
        static void Main(string[] args)
        {
            try
            {
                Garage garage = new Garage();
                bool flag = true;

                while (flag)
                {
                    garage.WorkWithVehicles();
                }
            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
