using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp128
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, i, j;
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[m, n];
            for (i = 0; i < m; i++)
                for (j = 0; j < n; j++)
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < (m / 2); i++)
                for (j = 0; j < (n / 2); j++)
                {
                    int c, ii, jj;
                    ii = m / 2 + i;
                    jj = n / 2 + j;
                    c = a[i, j];
                    a[i, j] = a[ii, jj];
                    a[ii, jj] = c;
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
