using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp95
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, s = 0, k = 0;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (i = 0; i < n; i++)
                a[i] = Convert.ToInt32(Console.ReadLine());
            int[] b = new int[n];
            for (i = 0; i < n; i++)
            {
                s = s + a[i];
                k++;
                b[i] = s / k;
            }
            for (i = 0; i < n; i++)
                Console.WriteLine("b[" + i + "]=" + b[i]);
            Console.ReadKey();
        }
    }
}
