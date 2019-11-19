using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp87
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < (n/2); i++)
                Console.WriteLine("a[" + (i * 2 + 1) + "]=" + a[i * 2 + 1]);
            for (int i = (n - 1)/2; i >= 0; i--)
                Console.WriteLine("a[" + (i * 2) + "]=" + a[i * 2]);
            Console.ReadKey();

        }
    }
}
