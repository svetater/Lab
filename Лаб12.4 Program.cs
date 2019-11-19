using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp81
{
    class Program
    {
        public static void Quarter(int x, int y)
        {
            if (x > 0)
            {
                if (y > 0)
                { Console.WriteLine("1"); }
                else
                { Console.WriteLine("4"); }
            }
            else
            {
                if (y > 0)
                { Console.WriteLine("2"); }
                else
                { Console.WriteLine("3"); }
            }
        }
        static void Main(string[] args)
        {
            int x, y;
            for (int i=0;i<3;i++)
            {
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                Quarter(x, y);
            }
            Console.ReadKey();
        }
    }
}
