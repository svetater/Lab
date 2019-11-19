using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp82
{
    class Program
    {
        public static void Fact2(float n)
        {
            float f=1;
            if ((n%2)==0)
            { for (float i=2;i<=n;i=i+2)
                { f = f * i; }     
            }
            else
            {
                for (float i = 1; i <= n; i = i + 2)
                { f = f * i; }
            }
            Console.WriteLine(f);
        }
        static void Main(string[] args)
        {
            float n;
            n = Convert.ToInt32(Console.ReadLine());
            Fact2(n);
            Console.ReadKey();
        }
    }
}
