using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp145
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            s = Convert.ToString(Console.ReadLine());
            int i, n, k = 0;
            n = s.Length;
            for (i = 0; i < n; i++) 
            {
                if (s[i] == '/' || s[i] == '.')
                {
                    k++;
                    i++;
                }
                if (k == 1)
                    Console.Write(s[i]);
            }
            Console.ReadKey();
        }
    }
}
