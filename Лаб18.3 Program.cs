using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp123
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, i, j, min, pmin, p, jmin = 0;
            pmin = 0;
            min = 100000000;
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[m, n];
            for (i = 0; i < m; i++)
                for (j = 0; j < n; j++)
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
            for (j = 0; j < n; j++)
            {
                p = 1;
                for (i = 0; i < n; i++)
                    p = p * a[i, j];
                if (p < min)
                {
                    min = p;
                    jmin = j;
                }
            }
            Console.WriteLine("Nomer ctolba:" + jmin + " proizved:" + min);
            Console.ReadKey();
        }
    }
}
