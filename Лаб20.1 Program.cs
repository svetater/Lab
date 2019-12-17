using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp133
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            int n;
            c = Convert.ToChar(Console.ReadLine());
            n = (int)(c);
            Console.WriteLine((char)(n - 1));
            Console.WriteLine((char)(n));
            Console.WriteLine((char)(n + 1));
            Console.ReadKey();
        }
    }
}
