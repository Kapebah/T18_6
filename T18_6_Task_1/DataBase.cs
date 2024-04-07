using System;
using System.Collections.Generic;
using static System.Console;

namespace T18_6_Task_1
{
    enum Action { Add = 1, Output, AcceptableToUse, Exit }
    enum TypeOfSoftware { Free = 1, ConditionalFree, Commercial, Exit }
    /// <summary>
    /// База
    /// </summary>
    class DataBase
    {
        /// <summary>
        /// База, куда записывается вся информация
        /// </summary>
        List<Software> softwares = new List<Software>();
        /// <summary>
        /// Метод, позволяющий работать со всеми потомками
        /// </summary>
        public void WorkWithSoftwares()
        {
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Choose an action: ");
            ResetColor();
            WriteLine("\t\t1 - Add software\n\t\t2 - Output all information\n\t\t3 - Find out what software is acceptable to use as of the current date\n\t\t4 - Exit");
            if (Enum.TryParse(ReadLine(), out Action action))
            {
                ///Выбор действия, которое хотим осуществить
                switch (action)
                {
                    ///Добавить объект
                    case Action.Add:
                        Clear();
                        ForegroundColor = ConsoleColor.Green;
                        WriteLine("Choose a type of software: ");
                        ResetColor();
                        WriteLine("\t\t1 - Free\n\t\t2 - Conditional free\n\t\t3 - Commercial\n\t\t4 - Exit");
                        if (Enum.TryParse(ReadLine(), out TypeOfSoftware type))
                        {
                            switch (type)
                            {
                                case TypeOfSoftware.Free:
                                    Clear();
                                    softwares.Add(Free.Input());
                                    break;
                                case TypeOfSoftware.ConditionalFree:
                                    Clear();
                                    softwares.Add(ConditionalFree.Input());
                                    break;
                                case TypeOfSoftware.Commercial:
                                    Clear();
                                    softwares.Add(Commercial.Input());
                                    break;
                                case TypeOfSoftware.Exit:
                                    Environment.Exit(0);
                                    break;
                            }
                        }
                        else { WriteLine("Wrong! Try again."); }
                        break;
                    ///Вывести информацию об объектах
                    case Action.Output:
                        Clear();
                        ForegroundColor = ConsoleColor.Green;
                        WriteLine("All information about software: \n");
                        ResetColor();
                        foreach (var elem in softwares)
                        {
                            WriteLine(elem.ToString());
                            WriteLine();
                        }
                        break;
                    ///Вывести все ПО, доступные на текущее время 
                    case Action.AcceptableToUse:
                        Clear();
                        ForegroundColor = ConsoleColor.Green;
                        WriteLine("All softwares are acceptable to use as of the current date: \n");
                        ResetColor();
                        foreach (var elem in softwares)
                        {
                            if (elem is Free)
                            {
                                WriteLine(elem.Name);
                            }
                            else if (elem is ConditionalFree conditionalFree)
                            {
                                if ((DateTime.Now - conditionalFree.DateOfInstallation).Days > conditionalFree.FreePeriod)
                                {
                                    WriteLine(conditionalFree.Name);
                                }
                            }
                            else if (elem is Commercial commercial)
                            {
                                if ((DateTime.Now - commercial.DateOfInstallation).Days > commercial.PeriodOfUsage)
                                {
                                    WriteLine(commercial.Name);
                                }
                            }
                        }
                        WriteLine();
                        break;
                    ///Выйти из консоли
                    case Action.Exit:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
