using System;
using static System.Console;

namespace T18_6_Task_1
{
    class Commercial : Software
    {
        /// <summary>
        /// Дата установки
        /// </summary>
        public DateTime DateOfInstallation { get; set; }
        /// <summary>
        /// Бесплатный период в днях
        /// </summary>
        public int PeriodOfUsage { get; set; }
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Commercial() { }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="name">Инициализация названия</param>
        /// <param name="manufacturer">Инициализация производителя</param>
        /// <param name="dateOfInstallation">Инициализация даты установки</param>
        /// <param name="freePeriod">Инициализация бесплатного периода в днях</param>
        public Commercial(string name, string manufacturer, DateTime dateOfInstallation, int periodOfUsage) : base(name, manufacturer)
        {
            DateOfInstallation = dateOfInstallation;
            PeriodOfUsage = periodOfUsage;
        }
        /// <summary>
        /// Переопределенный метод вывода
        /// </summary>
        /// <returns>Строка, выводящая информацию о платном ПО</returns>
        public override string ToString()
        {
            return $"Name: {Name}\nManufacturer: {Manufacturer}\nDate of create: {DateOfInstallation}\nUsage period in days: {PeriodOfUsage}";
        }
        /// <summary>
        /// Ввод информации
        /// </summary>
        /// <returns>Объект класса Commercial</returns>
        public static Commercial Input()
        {
            Write("Enter the name: ");
            string name = ReadLine();
            Write("Enter the manufacturer: ");
            string manufacturer = ReadLine();
            Write("Enter the date of installation: ");
            DateTime dateOfInstallation = DateTime.Parse(ReadLine()); ;
            Write("Enter the usage period in days: ");
            int periodOfUsage = Convert.ToInt32(ReadLine());
            return new Commercial(name, manufacturer, dateOfInstallation, periodOfUsage);
        }
    }
}
