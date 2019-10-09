using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp44
{
    class Program
    {
        static void Main(string[] args)
        {
            int k, a, b, c, d;
            Console.WriteLine("Введите число ");
            k = Convert.ToInt32(Console.ReadLine());
            a = k / 1000;
            b = (k % 1000) / 100;
            c = (k % 100) / 10;
            d = k % 10;
            if ((a==d)&&(b==c))
            { Console.WriteLine("True"); }
            else
            { Console.WriteLine("False"); }
            Console.ReadKey();

        }
    }
}
