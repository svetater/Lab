using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp143
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            char p;
            s = Convert.ToString(Console.ReadLine());
            int n, i;
            n = s.Length;
            i = 1;
            p = s[0];
            Console.Write(s[0]);
            while (i < n)
            {
                if (s[i] == p)
                    Console.Write(".");
                else if (s[i] != ' ') 
                    Console.Write(s[i]);
                else
                {
                    i++;
                    p = s[i];
                    Console.Write(" "+s[i]);
                }
                i++;   
            }
            Console.ReadKey();
        }
    }
}
