using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp147
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
          
            s = Convert.ToString(Console.ReadLine());
            int n, i;
            n = s.Length;
            for (i = 0; i < n; i++)
            {
                if (i % 2 != 0)
                    Console.Write(s[i]);
            }
            for (i = n - 1; i >= 0; i--) 
            {
                if (i % 2 == 0)
                    Console.Write(s[i]);
            }
            Console.ReadKey();
        }
    }
}
