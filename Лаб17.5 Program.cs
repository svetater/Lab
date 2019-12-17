using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp136
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, v, t, imax = 0, vmax = 0, tmax = 0;
            double d1, d2, d3, p, pmax = 0 ;
            n = Convert.ToInt32(Console.ReadLine());
            int[] ax = new int[n];
            int[] ay = new int[n];
            for ( i = 0; i < n; i++)
            {
                Console.WriteLine("Tochka " + i);
                ax[i] = Convert.ToInt32(Console.ReadLine());
                ay[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n - 2; i++)
            {
                v = i + 1;
                while ( v < n-1)
                {
                    t = v + 1;
                    while ( t < n)
                    {
                        d1 = Math.Sqrt(Math.Pow(ax[t] - ax[v], 2) + Math.Pow(ay[t] - ay[v],2));
                        d2 = Math.Sqrt(Math.Pow(ax[v] - ax[1], 2) + Math.Pow(ay[v] - ay[i], 2));
                        d3 = Math.Sqrt(Math.Pow(ax[t] - ax[i], 2) + Math.Pow(ay[t] - ay[i], 2));
                        if (((d1 + d2) > d3) && ((d2 + d3) > d1) && ((d1 + d3) > d2))
                        {
                            p = d1 + d2 + d3;
                            if (p > pmax)
                            {
                                pmax = p;
                                imax = i;
                                vmax = v;
                                tmax = t;
                            }
                        }
                        t++;                        
                    }
                    v++;
                }
            }
            Console.WriteLine("T1(" + ax[imax] + ";" + ay[imax] + ")");
            Console.WriteLine("T2(" + ax[vmax] + ";" + ay[vmax] + ")");
            Console.WriteLine("T3(" + ax[tmax] + ";" + ay[tmax] + ")");
            Console.ReadKey();
        }
    }
}
