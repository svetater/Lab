using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp114
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, l;
            l = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (i = 0; i < n; i++)
                a[i] = Convert.ToInt32(Console.ReadLine());
            i = 0;
            while (i < n)
            {
                int j, k;
                j = i + 1;
                k = 1;
                while ((j < n) && (j != 0))
                {
                    if (a[i] == a[j])
                    {
                        k++;
                        if ((k > l) || (j == (n - 1)))
                        {
                            int c;
                            c = 1;
                            a[i] = 0;
                            j++;

                            while (j < n)
                            {
                                a[i + c] = a[j];
                                c++;
                                j++;

                            }
                            n = n - k + 1;
                            i++;

                        }
                    }

                    else if (k > l)
                    {
                        int c;
                        c = 1;
                        a[i] = 0;

                        while (j < n)
                        {
                            a[i + c] = a[j];
                            c++;
                            j++;

                        }
                        n = n - k + 1;
                        i++;


                        for (i = 0; i < n; i++)
                            Console.WriteLine("a[" + i + "]=" + a[i]);
                    }
                    else
                    {
                        i = j;
                        j = -1;
                    }
                    
                    j++;
                }
            }
            for (i = 0; i < n; i++)
                Console.WriteLine("a[" + i + "]=" + a[i]);
            Console.ReadKey();
        }
    }
}
