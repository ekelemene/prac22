using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //экземпляр с без параметров и присваивания значений полям объекта
            Calculate calc1 = new Calculate();
            calc1.Num1 = 2;
            calc1.Num2 = 4;
            Console.WriteLine(calc1.GetInfo());
            Console.WriteLine("результат:" + calc1.CalcNum());
            Console.WriteLine();
            //экземпляр  с явной инициализацией
            Calculate calc2 = new Calculate(2,3);
            Console.WriteLine(calc2.GetInfo());
            Console.WriteLine("результат:" + calc2.CalcNum());
            Console.WriteLine();
            //экземпляр  с  использованием конструктора с двумя параметрами, введенными с клавиатуры.
            Console.Write("введите число: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("введите число: ");
            int num2 = int.Parse(Console.ReadLine());
            Calculate calc3 = new Calculate(num1, num2);
            Console.WriteLine(calc3.GetInfo());
            Console.WriteLine("результат:" + calc3.CalcNum());

        }
    }
}
