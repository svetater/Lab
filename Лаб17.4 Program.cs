using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp119
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, imax = 0;
            double r, max ;
            max = 0;
            n = Convert.ToInt32(Console.ReadLine());
            int[] ax = new int[n];
            int[] ay = new int[n];
            for ( i = 0; i < n; i++)
            {
                ax[i] = Convert.ToInt32(Console.ReadLine());
                ay[i] = Convert.ToInt32(Console.ReadLine());
            }
            for ( i = 0; i < n; i++)
            {
                if ( (ax[i] < 0) && ( ay[i] > 0))
                {
                    r = Math.Sqrt(ax[i] * ax[i] + ay[i] * ay[i]);
                    if (r > max)
                    {
                        max = r;
                        imax = i;
                    }
                }
            }
            if (max == 0)
                Console.WriteLine("A(0;0)");
            Console.WriteLine("A(" + ax[imax] + ";" + ay[imax] + ")");
            Console.ReadKey();
        }
    }
}
