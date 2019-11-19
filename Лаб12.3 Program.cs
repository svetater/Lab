using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp80
{
    class Program
    {
        public static void Rings(float r1, float r2)
        {
            
            double s, p=3.14;
            s = p * r1 - p * r2;
            Console.WriteLine(s);

        }
        static void Main(string[] args)
        {
            float r1, r2;
            for (int i=0;i<3;i++)
            {
                r1 = Convert.ToInt32(Console.ReadLine());
                r2 = Convert.ToInt32(Console.ReadLine());
                Rings(r1, r2);
            }
            Console.ReadKey();
        }
    }
}
