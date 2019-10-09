using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1, b1, c1, a2, b2, c2;
            double x, y;
            Console.WriteLine("Введите коэффиценты ");
            a1 = Convert.ToInt32(Console.ReadLine());
            b1 = Convert.ToInt32(Console.ReadLine());
            c1 = Convert.ToInt32(Console.ReadLine());
            a2 = Convert.ToInt32(Console.ReadLine());
            b2 = Convert.ToInt32(Console.ReadLine());
            c2 = Convert.ToInt32(Console.ReadLine());
            y = (c2 * a1 - c1 * a2) / (b2 * a1 - b1 * a2);
            x = (c1 - b1 * y) / a1;
            Console.WriteLine("x=" + x);
            Console.WriteLine("y=" + y);
            Console.ReadKey();

        }
    }
}
