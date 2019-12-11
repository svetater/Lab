using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp104
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, l=0, c=0;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (i = 0; i < n; i++)
                a[i] = Convert.ToInt32(Console.ReadLine());
            i = 0;
            while (i<n)
            {
                int j = 0, k = 0;
                while (j < n)
                {
                    if (a[i] == a[j])
                    {
                        k++;
                        l = j;
                    }
                    j++;
                }
                if (k == 2)
                {
                    c = i;


                    if (l < (n - 1))
                    {
                        while ((l + 1) < n)
                        {
                            a[l] = a[l + 1];
                            l++;
                        }
                        n--;
                    }
                    else
                        n--;
                    while ((c + 1) < n)
                    {
                        a[c] = a[c + 1];
                        c++;

                    }
                    n--;

                }
                else
                    i++;
            }
            for (i = 0; i < n; i++)
                Console.WriteLine("a[" + i + "]=" + a[i]);
            Console.ReadKey();
        }
    
    }
}
