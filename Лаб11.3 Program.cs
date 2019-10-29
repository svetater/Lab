using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp63
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, s=0, k=0;
            n = Convert.ToInt32(Console.ReadLine());
            while (s<n)
            {
                k++;
                s = s + k;               
            }
            Console.WriteLine(k);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
