using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp76
{
    class Program
    {
        public static void PowerA3(float a, float b)
        {
            b = a * a * a;
            Console.WriteLine("a^3=" + b);
        }
        static void Main(string[] args)
        {
            float a, b=1;
            for (int i=0;i<3;i++)
            {
                a = Convert.ToInt32(Console.ReadLine());               
                PowerA3(a, b);
            }
            Console.ReadKey();

        }
    }
}
