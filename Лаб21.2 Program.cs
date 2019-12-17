using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp142
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int n, i, d = 0, dmin = 1000000;
            s = Convert.ToString(Console.ReadLine());
            n = s.Length;
            i = 0;
            while (i < n)
            {
                if (s[i] != ' ')
                {
                    d++;
                }
                else
                {
                    if (d < dmin)
                        dmin = d;
                    d = 0;
                }
                i++;               
            }
            Console.WriteLine(dmin);
            Console.ReadKey();
        }
    }
}
