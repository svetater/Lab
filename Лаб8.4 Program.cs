using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp50
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("A");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            if (x < 0)
            {
                if (y < 0)
                {
                    Console.WriteLine("Третья четверть");
                }
                else
                {
                    Console.WriteLine("Вторая четверть");
                }
            }
            else
            {
                if (y < 0)
                {
                    Console.WriteLine("Четвертая четверть");
                }
                else
                {
                    Console.WriteLine("Первая четверть");
                }
            }
            Console.ReadKey();

        }
    }
}
