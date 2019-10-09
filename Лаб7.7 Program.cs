using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("введите стороны");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if (((a+b)>c)&&((a+c)>b)&&((b+c)>a))
            { Console.WriteLine("True"); }
            else
            { Console.WriteLine("False"); }
            Console.ReadKey();
        }
    }
}
