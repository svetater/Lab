using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp137
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int i, n;
            s = Convert.ToString(Console.ReadLine());
            n = s.Length;
            for (i = 0; i < n; i++)
            {
                Console.Write(s[i] + " ");
            }
            Console.ReadKey();



        }
    }
}
