using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp144
{
    class Program
    {
        static void Main(string[] args)
        {
            string s, g;
            s = Convert.ToString(Console.ReadLine());
            g = "ауеыоэёяиюУЕОЁАЭЯИЮ";
            int n, m, i, k = 0, j;
            n = s.Length;
            m = g.Length;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                    if (s[i] == g[j])
                        k++;
            }
            Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}
