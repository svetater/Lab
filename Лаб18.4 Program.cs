using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp124
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, i, j, s, k;
            double c;
            s = 0;
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[m, n];
            for (i = 0; i < m; i++)
                for (j = 0; j < n; j++)
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < m; i++)
                for (j = 0; j < n; j++)
                {
                    s = s + a[i, j];
                }
            c = s / (m * n);
            Console.WriteLine(c);
            for (j = 0; j < m; j++)
            {
                k = 0;
                for (i = 0; i < n; i++)
                    if (a[i, j] > c)
                        k++;
                Console.WriteLine("Ctolb " + j + ":" + k);
            }
            Console.ReadKey();
        }
    }
}
