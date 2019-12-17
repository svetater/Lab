using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp139
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            char c;
            int n, i;
            s = Convert.ToString(Console.ReadLine());
            c = Convert.ToChar(Console.ReadLine());
            n = s.Length;
            for (i = 0; i < n; i++)
            {
                if (s[i] == c)
                {
                    Console.Write(s[i]);
                    Console.Write(s[i]);
                }
                else
                    Console.Write(s[i]);
            }
            Console.ReadKey();
        }
    }
}
