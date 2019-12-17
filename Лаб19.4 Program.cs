using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp129
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, i, j, k;
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[m, n];
            for (i = 0; i < m; i++)
                for (j = 0; j < n; j++)
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
            for (k = 0; k < m; k++)
            {
                for (i = 0; i < m - 1; i++)
                    if (a[i, 0] > a[i + 1, 0])
                    {
                        for (j = 0; j < n; j++)
                        {
                            int c;
                            c = a[i, j];
                            a[i, j] = a[i + 1, j];
                            a[i + 1, j] = c;
                        }
                    }
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
