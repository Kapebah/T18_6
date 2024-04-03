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
        enum Action { Add = 1, Output, Exit }
        static void Main(string[] args)
        {
            try
            {
                Garage garage = new Garage();
                bool flag = true;

                while (flag)
                {
                    WriteLine("Choose an action: ");
                    if(Enum.TryParse(ReadLine(), out Action action))
                    {
                        switch (action)
                        {
                            case Action.Add:
                                garage.AddVehicle();
                                break;
                            case Action.Output:
                                garage.OutputVehicle();
                                break;
                            case Action.Exit:
                                Environment.Exit(0);
                                break;
                        }
                    }
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
