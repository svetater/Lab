using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp127
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, i, j, min, max, jmin = 0, jmax = 0;
            min = 100000000;
            max = 0;
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[m, n];
            for (i = 0; i < m; i++)
                for (j = 0; j < n; j++)
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
            for ( i = 0; i < m; i++)
                for ( j = 0; j < n; j++)
                {
                    if (a[i,j] < min)
                    {
                        min = a[i, j];
                        jmin = j;
                    }
                    if ( a[i,j] > max)
                    {
                        max = a[i, j];
                        jmax = j;
                    }
                }
            for ( i = 0; i < m; i++)
            {
                int c;
                c = a[i, jmax];
                a[i, jmax] = a[i, jmin];
                a[i, jmin] = c;
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
