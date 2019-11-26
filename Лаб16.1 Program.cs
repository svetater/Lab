using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp100
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (i = 0; i < n; i++)
                a[i] = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < (n-1); i++)
            {
                int d = i + 1;
                while (a[i] == a[d])
                {
                    d++;
                }
                if (d > (i + 1))
                {
                    d--;
                    int c = 1;
                    while ((d + c)< n)
                    {                        
                        a[i + c] = a[d + c];
                        c++;
                    }
                    n = n - (d - i);
                }
            }
            for (i = 0; i < n; i++)
                Console.WriteLine("a[" + i + "]=" + a[i]);
            Console.ReadKey();
        }
    }
}
