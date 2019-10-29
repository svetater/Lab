using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp66
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, p=0, s=1, k=3;
            n = Convert.ToInt32(Console.ReadLine());
            while (s!=n)
            {
                p = s-p;
                s = p + s;
                k++;
            }
            Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}
