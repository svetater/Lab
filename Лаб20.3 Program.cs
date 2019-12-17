using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp138
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            s = Convert.ToString(Console.ReadLine());
            int k = 0, n, i;
            n = s.Length;
            for (i = 0; i < n; i++)
            {
                if (s[i] <= 'Z' && s[i] >= 'A')
                    k++;
            }
            Console.WriteLine(k);
            Console.ReadKey();

        }
    }
}
