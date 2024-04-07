using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T18_6_Task_1
{
    /// <summary>
    /// Программное обеспечение
    /// </summary>
    abstract class Software
    {
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Производитель
        /// </summary>
        public string Manufacturer { get; set; }
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Software() { }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="name">Инициализация имени</param>
        /// <param name="manufacturer">Инициализация производителя</param>
        public Software(string name, string manufacturer)
        {
            Name = name; Manufacturer = manufacturer;
        }
        /// <summary>
        /// Метод вывода
        /// </summary>
        /// <returns>Строку, выводящую информацию</returns>
        public new abstract string ToString();
    }
}
