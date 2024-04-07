using System;
using static System.Console;

namespace T18_6_Task_1
{
    /// <summary>
    /// Бесплатное ПО
    /// </summary>
    class Free : Software
    {
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Free() { }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="name">Инициализация имени</param>
        /// <param name="manufacturer">Инициализация производителя</param>
        public Free(string name, string manufacturer) : base(name, manufacturer) { }
        /// <summary>
        /// Переопределенный метод вывода
        /// </summary>
        /// <returns>Строка с выводом информации о бесплатном ПО</returns>
        public override string ToString()
        {
            return $"Name: {Name}\nManufacturer: {Manufacturer}";
        }
        /// <summary>
        /// Ввод информации
        /// </summary>
        /// <returns>Объект класса Free</returns>
        public static Free Input()
        {
            Write("Enter the name: ");
            string name = ReadLine();
            Write("Enter the manufacturer: ");
            string manufacturer = ReadLine();
            return new Free(name, manufacturer);
        }
    }
}
