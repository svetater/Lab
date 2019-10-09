using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Введите стороны ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if ((a*a+b*b==c*c)||(a*a+c*c==b*b)||(b*b+c*c==a*a))
            { Console.WriteLine("True"); }
            else
            { Console.WriteLine("False"); }
            Console.ReadKey();
        }
    }
}
