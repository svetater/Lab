using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp122
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, i, j, k, p, s;
            p = 1;
            s = 0;
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[m, n];
            for ( i = 0; i < m; i++)
                for ( j = 0; j < n; j++)
                    a[i,j] = Convert.ToInt32(Console.ReadLine());
            k = Convert.ToInt32(Console.ReadLine());
            for ( j = 0; j < n; j++)
            {
                p = p * a[k-1, j];
                s = s + a[k-1, j];
            }
            Console.WriteLine("p=" + p + " s=" + s);
            Console.ReadKey();

        }
    }
}
