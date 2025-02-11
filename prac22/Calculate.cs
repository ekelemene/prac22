using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac22
{
    /// <summary>
    /// класс Calculate
    /// </summary>
    internal class Calculate : Program
    {
        //поля
        public double Num1;
        public double Num2;
        //конструктор без параметров
        public Calculate()
        {
            Num1 = 0;
            Num2 = 0;
        }
        //конструктор с 1 параметром 
        public Calculate(double num)
        {
            Num1 = num;
            Num2 = num;
        }
        //конструктор с 2 параметрами 
        public Calculate(double num1, double num2)
        {
            Num1 = num1;
            Num2 = num2;
        }
        //функция формирования строки с информацией об объекте;
        public string GetInfo()
        {
            return $"число 1: {Num1}, число 2: {Num2}";
        }
        //функция обработки значений полей
        public double CalcNum()
        {
            return Math.Sqrt(Num1 * Num2);
        }
    }
}
