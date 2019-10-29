using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp64
{
    class Program
    {
        static void Main(string[] args)
        {
            int p, k=0;
            float s =1000;
            p = Convert.ToInt32(Console.ReadLine());
            while (s<=1100)
            {
                s = s + ((p * s) / 100);
                k++;
            }
            Console.WriteLine(s);
            Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}
