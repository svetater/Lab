using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp106
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, m, k = 0;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (i = 0; i < n; i++)
                a[i] = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            int[] b = new int[m];
            for (i = 0; i < n; i++)
            {
                if (a[i]<0)
                {
                    b[i + k] = a[i];
                    b[i + (1 + k)] = 0;
                    k++;
                }
                else
                 b[i+k] = a[i];
            }
            for (i = 0; i < (n + k); i++)
                Console.WriteLine("a[" + i + "]=" + b[i]);
            Console.ReadKey();

        }
    }
}
