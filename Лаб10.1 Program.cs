using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp56
{
    class Program
    {
        static void Main(string[] args)
        {
            int c;
            float a;
            c = Convert.ToInt32(Console.ReadLine());
            for (float i=1; i<10; i++)
            { a = c * (i / 10);
                Console.WriteLine("0," + i + "=" + a);
            }
            Console.WriteLine("1=" + c);
            Console.ReadKey();
        }
    }
}
