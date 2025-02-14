using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //пример без параметров
            Calculate ob1 = new Calculate();
            Console.WriteLine(ob1.GetInfo());
            ob1.Num1 = 4;
            ob1.Num2 = 9;
            Console.WriteLine(ob1.GetInfo());
            Console.WriteLine("result = " + ob1.CalcNum());
            Console.WriteLine();
            //пример с явной инициализацией
            Calculate ob2 = new Calculate(1);
            Console.WriteLine(ob2.GetInfo());
            Calculate ob4 = new Calculate(7,3);
            Console.WriteLine(ob4.GetInfo());
            Console.WriteLine("result = " + ob4.CalcNum());
            Console.WriteLine();
            //пример введенный с клавиатуры
            Console.Write("num1 = ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("num2 = ");
            int num2 = int.Parse(Console.ReadLine());
            Calculate ob3 = new Calculate(num1,num2);
            Console.WriteLine(ob3.GetInfo());
            Console.WriteLine("result = "+ob3.CalcNum());

            Console.Read();


        }
    }
}
