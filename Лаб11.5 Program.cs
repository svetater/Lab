using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp65
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, o;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            do
            {
                o = a - b * (a / b);
                if (o == 0)
                    Console.WriteLine(b);
                a = b;
                b = o;               
            }
            while (o > 0);         
            Console.ReadKey();
        }
    }
}
