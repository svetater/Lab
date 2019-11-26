using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp92
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, max=0;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (i=0;i<n;i++)
            { a[i] = Convert.ToInt32(Console.ReadLine()); }
            for (i = 1; i < n - 1; i++)
            {
                if ((a[i] > a[i - 1]) && (a[i] > a[i + 1]) && (a[i] > max))
                { max = a[i]; }
            }
            Console.WriteLine("max=" + max);
            Console.ReadKey();
        }
    }
}
