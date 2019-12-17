using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp152
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, j, k, a, b, c = 0, d;
            k = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[n];
            int[] B = new int[n];


            for (i = 0; i < n; i++)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            a = 1;
            b = 0;
            d = (k == 1 ? 1 : 0);
            j = -1;
            for (i = 1; i < n; i++)
            {
                if (A[i - 1] != A[i])
                {
                    a++;
                    if (a == k) b = i;
                    c = i;
                }
                if (a == k) d++;
            }
            for (i = 0; i < b; i++) B[++j] = A[i];
            for (i = c; i < n; i++) B[++j] = A[i];
            for (i = b + d; i < c; i++) B[++j] = A[i];
            for (i = b; i < b + d; i++) B[++j] = A[i];
            for (i = 0; i < n; i++) A[i] = B[i];            
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("A[" + i + "]=" + A[i]);
               
            }
            Console.ReadKey();
        }
    }
}
