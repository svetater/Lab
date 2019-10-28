using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp49
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, y1, x2, y2, x3, y3;
            double ab, ac;        
            Console.WriteLine("A");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("C");
            x3 = Convert.ToInt32(Console.ReadLine());
            y3 = Convert.ToInt32(Console.ReadLine());
            ab = Math.Sqrt(Math.Pow((x2 - x1), 2) - Math.Pow((y2 - y1), 2));
            ac = Math.Sqrt(Math.Pow((x3 - x1), 2) - Math.Pow((y3 - y1), 2));
            if (ab>ac)
            { Console.WriteLine("C(" + x3 + ";" + y3 + ")");
                Console.WriteLine("ac" + ac);
            }
            else
            { Console.WriteLine("B(" + x2 + ";" + y2 + ")");
                Console.WriteLine("ab" + ab);           
            }
            Console.ReadKey();
        }
    }
}
