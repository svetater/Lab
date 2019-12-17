using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp121
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, i, j, k, h, c, d, r;
            m = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[m, m];
            for (i = 0; i < m; i++)
                for (j = 0; j < m; j++)
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
            j = 0;
            i = -1;
            k = 0;
            h = 1;
            c = 0;
            d = m;
            r = 0;
            while ( h <= ((m/2)+1))
            {
                
            if (k > i )
            {
                   
                i = i + h;
                while (i < d)
                {
                    Console.WriteLine(a[i, k]);
                    i++;
                }
                k = i - 1;
            }
            else
            {

                    if (r == 1)
                    {
                        h--;
                        i = i - h;
                        h++;
                    }
                    else
                        i = i - h;
                while (i >= c)
                {
                    Console.WriteLine(a[i, k]);
                    i--;
                }
                k = i + 1;
                    c++;


            }
            if (k > j)
            {

                j = j + h;
                while (j < d)
                {
                    Console.WriteLine(a[k, j]);
                    j++;
                }
                k = j - 1;
                    d--;
                    h++;
            }
            else
            {
                    if ( r == 1)
                    {
                        h--;
                        j = j - h;
                        h++;
                    }
                    else
                j = j - h;
                while (j >= c)
                {
                    Console.WriteLine(a[k, j]);
                    j--;
                }
                    k = j + 1;
                    r++;
                    

            }
            
            }

           

            Console.ReadKey();
        }
    }
}
