using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace T18_6_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DataBase dataBase = new DataBase();
                bool flag = true;

                while (flag)
                {
                    dataBase.WorkWithSoftwares();
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
