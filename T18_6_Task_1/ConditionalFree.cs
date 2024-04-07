using System;
using static System.Console;

namespace T18_6_Task_1
{
    /// <summary>
    /// Условно-бесплатное ПО
    /// </summary>
    class ConditionalFree : Software
    {
        /// <summary>
        /// Дата установки
        /// </summary>
        public DateTime DateOfInstallation { get; set; }
        /// <summary>
        /// Бесплатный период в днях
        /// </summary>
        public int FreePeriod { get; set; }
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public ConditionalFree() { }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="name">Инициализация названия</param>
        /// <param name="manufacturer">Инициализация производителя</param>
        /// <param name="dateOfInstallation">Инициализация даты установки</param>
        /// <param name="freePeriod">Инициализация бесплатного периода в днях</param>
        public ConditionalFree(string name, string manufacturer, DateTime dateOfInstallation, int freePeriod) : base(name, manufacturer)
        {
            DateOfInstallation = dateOfInstallation;
            FreePeriod = freePeriod;
        }
        /// <summary>
        /// Переопределенный метод вывода
        /// </summary>
        /// <returns>Строка, выводящая информацию о условно-бесплатном ПО</returns>
        public override string ToString()
        {
            return $"Name: {Name}\nManufacturer: {Manufacturer}\nDate of create: {DateOfInstallation}\nFree usage period in days: {FreePeriod}";
        }
        /// <summary>
        /// Ввод информации
        /// </summary>
        /// <returns>Объект класса ConditionalFree</returns>
        public static ConditionalFree Input()
        {
            Write("Enter the name: ");
            string name = ReadLine();
            Write("Enter the manufacturer: ");
            string manufacturer = ReadLine();
            Write("Enter the date of installation: ");
            DateTime dateOfInstallation = DateTime.Parse(ReadLine()); ;
            Write("Enter the free usage period in days: ");
            int freePeriod = Convert.ToInt32(ReadLine());
            return new ConditionalFree(name, manufacturer, dateOfInstallation, freePeriod);
        }
    }
}
