using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp57
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            float p=1;
            n = Convert.ToInt32(Console.ReadLine());
            for (float i=1;i<=n;i++)
            {
                p = p * (1 + (i / 10));
            }
            Console.WriteLine(p);
            Console.ReadLine();
        }
    }
}
