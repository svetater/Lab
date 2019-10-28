using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp58
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k=0;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i=1;i<=n; i++)
            {
                k = k + (2 * i - 1);
                Console.WriteLine("k=" + k);
            }
            Console.ReadKey();
        }
    }
}
