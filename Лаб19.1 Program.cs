using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp126
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, i, j, min, max, jmin = 0, jmax = 0;
           
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[m, n];
            for (i = 0; i < m; i++)
                for (j = 0; j < n; j++)
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < m; i++)
            {
                min = 10000000;
                max = 0;
                for (j = 0; j < n; j++)
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                        jmax = j;
                    }
                    if (a[i, j] < min)
                    {
                        min = a[i, j];
                        jmin = j;
                    }
                }
                a[i, jmin] = max;
                a[i, jmax] = min;
            }
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                    Console.Write(a[i, j] + " ");
                Console.WriteLine();
            }
                Console.ReadKey();
        }
    }
}
