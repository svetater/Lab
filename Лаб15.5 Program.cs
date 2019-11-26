using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp98
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, d = 0;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (i = 0; i < n; i++)
                a[i] = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i < n; i++)
                if (a[d] > a[i])
                {
                    int c;
                    c = a[d];
                    a[d] = a[i];
                    a[i] = c;
                    d = i;
                }
            for (i = 0; i < n; i++)
            { Console.WriteLine("a[" + i + "]=" + a[i]); }
            Console.ReadKey();
        }
    }
}
