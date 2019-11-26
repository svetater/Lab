using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp94
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            int[] b = new int[n];
            for (i = 0; i < n; i++)
                a[i] = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
                b[i] = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                int c;
                c = a[i];
                a[i] = b[i];
                b[i] = c;
            }
            for (i = 0; i < n; i++)
                Console.WriteLine("a[" + i + "]=" + a[i]);
            for (i = 0; i < n; i++)
                Console.WriteLine("b[" + i + "]=" + b[i]);
            Console.ReadKey();

        }
    }
}
