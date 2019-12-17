using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp140
{
    class Program
    {
        static void Main(string[] args)
        {
            string s, s1;
            int n, n1, i, k = 0;
            s = Convert.ToString(Console.ReadLine());
            s1 = Convert.ToString(Console.ReadLine());
            n = s.Length;
            n1 = s.Length;
            if (n1 < n)
            {
                int c;
                c = n1;
                n1 = n;
                n = c;
            }
            for (i = 0; i < n; i++)
            {
                if (s[i] == s1[i])
                    k++;
            }
            Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}
