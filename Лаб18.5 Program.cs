using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp125
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, i, j, k, r, l;
            r = 0;
            l = 0;
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[m, n];
            for (i = 0; i < m; i++)
                for (j = 0; j < n; j++)
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
            
                for (j = 0; j < n; j++)
                {
                    k = 0;
                    for (i = 0; i < m; i++)
                        if (a[i, j] < 0)
                            k++;
                if (k == m)
                {
                    while (r == 0)
                    {
                        Console.WriteLine("Ctolb:" + j);
                        r++;
                    }
                }
                else
                    l++;
                    

                }
            if (l == n)
                Console.WriteLine("0");

            
            Console.ReadKey();
                
        }
    }
}
