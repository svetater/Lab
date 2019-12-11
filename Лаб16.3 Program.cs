using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp105
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, max = 0, imax = 0, min = 1000, imin = 0, m;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (i = 0; i < n-2; i++)
                a[i] = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n-2; i++)
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
            m = n-2;
            while (m != imin) 
            {
                a[m] = a[m - 1];
                m--;
            }
            a[m] = 0;          
            m = n-1;
            while (m != (imax+1)) 
            {
                a[m] = a[m - 1];
                m--;
            }
            a[m+1] = 0;
            for (i = 0; i < n; i++)
                Console.WriteLine("a[" + i + "]=" + a[i]);
            Console.ReadKey();
        }
    }
}
