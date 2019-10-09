using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {
            int g, v, o;
            Console.WriteLine("Введите год");
            g = Convert.ToInt32(Console.ReadLine());
            v = g / 100;         
            o = g % 10;        
            if (o==0)
            { Console.WriteLine("Век: " + v); }
            else
            { v++;
                Console.WriteLine("Век: " + v);
            }
            Console.ReadKey();
        }
    }
}
