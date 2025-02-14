using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    /// <summary>
    /// класс описывающий вычисления
    /// </summary>
    class Calculate
    {
        /// <summary>
        /// поля с переменными 
        /// </summary>
        private double num1;
        private double num2;

        public double Num1 { get => num1; set  { if (value < 0) throw new ArgumentException("error"); num1 = value; } }
        public double Num2 { get => num2; set  { if (value < 0) throw new ArgumentException("error"); num2 = value; } }

        

        /// <summary>
        /// конструктор без парам
        /// </summary>
        public Calculate()
        {
            Num1 = 0;
            Num2 = 0;
        }
        /// <summary>
        /// конструктор с 1 параметром
        /// </summary>
        /// <param name="Num1"></param>
        public Calculate(double num_1)
        {
            this.Num1 = num_1;
            this.Num2 = 0;
        }
        /// <summary>
        /// конструктор с 2 параметрами 
        /// </summary>
        /// <param name="Num1"></param>
        /// <param name="Num2"></param>
        public Calculate(double num_1,double num_2)
        {
            this.Num1 = num_1;
            this.Num2 = num_2;
        }
        /// <summary>
        /// функция вывода строки
        /// </summary>
        /// <returns></returns>
        public string GetInfo()
        {
            return $"num1 = {Num1} \nnum2 = {Num2}";
        }
        /// <summary>
        /// метод для вычисления кв корня
        /// </summary>
        /// <returns></returns>
        public double CalcNum()
        {
            return Math.Sqrt(Num1 * Num2);
        }




    }
}
