using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp91
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, min=1000;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (i=0;i<n;i++)
            {
                Console.WriteLine("a[" + i + "]=");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < (n / 2); i++)
            {
                if (a[2*i]<min)
                { min = a[i * 2]; }   
            }
            Console.WriteLine("min=" + min);
            Console.ReadKey();

        }
    }
}
