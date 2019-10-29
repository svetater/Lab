using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp61
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            while (a<=b)
            { for (int i = 1; i <= a; i++)
                    Console.WriteLine(a);
                a++;
            }
            Console.ReadKey();
        }
    }
}
