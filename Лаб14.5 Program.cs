using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp93
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, k=1;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (i=0;i<n;i++)
            { a[i] = Convert.ToInt32(Console.ReadLine());}
            for (i=0;i<n;i++)
            {
                while (k<n)
                {
                    if (a[i] == a[k])
                    { Console.WriteLine(i + " " + k); }
                    k++;
                }
                k = i + 2;
            }
            Console.ReadKey();
        }
    }
}
