using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp97
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, max = 0, min = 1000, imin = 0, imax = 0;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (i = 0; i < n; i++)
                a[i] = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                    imin = i;
                }
                if (a[i] > max)
                {
                    max = a[i];
                    imax = i;
                }
            }
            if (imin < imax)
            {
                for (i = imin + 1; i < imax; i++)
                    a[i] = 0;
            }
            else
            {
                for (i = imax + 1; i < imin; i++)
                    a[i] = 0;
            }
            for (i = 0; i < n; i++)
                Console.WriteLine("a[" + i + "]=" + a[i]);
            Console.ReadKey();
        }
    }
}
