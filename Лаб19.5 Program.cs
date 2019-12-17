using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp131
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, i, j, s, k;
            m = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[m, m];
            for (i = 0; i < m; i++)
                for (j = 0; j < m; j++)
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
            for (i = m - 1; i >= 0; i--)
            {
                j = 0;
                s = 0;
                k = i;
                while ((j < m) && (k < m))
                {
                    s = s + a[k, j];
                    j++;
                    k++;
                }
                Console.WriteLine(s);
            }
            for ( j = 1; j < m; j++)
            {
                i = 0;
                s = 0;
                k = j;
                while ((i < m) && (k < m))
                {
                    s = s + a[i, k];
                    i++;
                    k++;
                }
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
