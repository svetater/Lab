using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp59
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, n;
            double s=1;
            a = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            for (int i=1;i<=n;i++)
            { 
               s = s +(Math.Pow(a,i));
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
