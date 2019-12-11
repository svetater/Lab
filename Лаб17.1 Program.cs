using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp112
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, m, h, k, j;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (i = 0; i < n; i++)
                a[i] = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            int[] b = new int[m];
            int[] c = new int[m];
            h = 0;
            i = 0;
            while (i < n)
            {

                k = 1;
                j = i + 1;
                while ((j < n) && (j != 0))
                {
                    if (a[i] == a[j])
                    {
                        k++;
                        c[h] = a[i];
                        b[h] = k;
                    }
                    else if (k == 1)
                    {
                        b[h] = k;
                        c[h] = a[i];
                        Console.WriteLine("b[" + h + "]=" + b[h]);
                        Console.WriteLine("c[" + h + "]=" + c[h]);
                        i = j;
                        j = -1;
                        h++;
                    }
                    else
                    {
                        Console.WriteLine("b[" + h + "]=" + b[h]);
                        Console.WriteLine("c[" + h + "]=" + c[h]);
                        h++;
                        i = j;
                        j = -1;
                    }
                    if ((i == (n - 1)) || (j ==(n-1)))
                    {
                        b[h] = k;
                        c[h] = a[i];
                        Console.WriteLine("b[" + h + "]=" + b[h]);
                        Console.WriteLine("c[" + h + "]=" + c[h]);
                        i++;
                    }
                    j++;

                }
            }
            Console.ReadKey();
        }
    }
}
