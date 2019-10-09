using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    class Program
    {
        static void Main(string[] args)
        {
            int k, a, b, c;
            Console.WriteLine("Введите число ");
            k = Convert.ToInt32(Console.ReadLine());
            a = k / 100;
            b = (k % 100) / 10;
            c = k % 10;
            if (((a<b)&&(b<c))||((a>b)&&(b>c)))
            { Console.WriteLine("True"); }
            else
            { Console.WriteLine("False"); }
            Console.ReadKey();
        }
    }
}
