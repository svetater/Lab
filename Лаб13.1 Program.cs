using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp83
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;        
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i=0;i<n;i++)
            {
                a[i] =(2 * i) + 1;
            }
            for (int i=0;i<n;i++)
            {
                Console.WriteLine("a[" + i + "]=" + a[i]);
            }
            Console.ReadKey();

        }
    }
}
