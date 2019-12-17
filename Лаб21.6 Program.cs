using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp146
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            s = Convert.ToString(Console.ReadLine());
            int n, i, k = 0, c = 0;
            n = s.Length;
            for (i = 0; i < n; i++) 
            {
                if (s[i] == '/')
                {
                    k++;
                    c = i;
                }
            }
            if (k == 1)
            {
                Console.Write("/");
            }
            else
            {
                for (i = 0; i < n-1; i++)
                {
                    if (s[i] == '/')
                        k--;
                    if (k == 1 && s[i]!='/')
                        Console.Write(s[i]);
                }
            }
            Console.ReadKey();
        }
        
    }
}
