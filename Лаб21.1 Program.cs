using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp141
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            s = Convert.ToString(Console.ReadLine());
            int n, i, k = 1;
            n = s.Length;
            for (i = 0; i < n; i++)
            {
                if (s[i] == ' ')
                    k++;
            }
            Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}
