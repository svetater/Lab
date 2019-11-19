using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp85
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            a[0] = Convert.ToInt32(Console.ReadLine());
            a[1] = Convert.ToInt32(Console.ReadLine());
            for (int i=2;i<n;i++)
            {
                int k = 0;
                while (k<i)
                {
                    a[i] = a[i] + a[k];
                    k++;
                }
            }
            for (int i=0;i<n;i++)
            {
                Console.WriteLine("a[" + i + "]=" + a[i]);
            }
            Console.ReadKey();
        }
    }
}
