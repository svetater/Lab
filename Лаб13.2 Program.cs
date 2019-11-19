using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp84
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            double[] a = new double[n];
            a[0] = Convert.ToInt32(Console.ReadLine());
            int d;
            d = Convert.ToInt32(Console.ReadLine());
            for (int i=1;i<n;i++)
            {
                a[i] = a[0] * Math.Pow(d, i);
            }
            for (int i=0;i<n;i++)
            {
                Console.WriteLine("a[" + i + "]=" + a[i]);
            }
            Console.ReadKey();
        }
    }
}
