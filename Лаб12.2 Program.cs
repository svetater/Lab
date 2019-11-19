using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp79
{
    class Program
    {
        public static void Sign(float x, float s=0)
        {
            for (int i = 0; i < 2; i++)
            {
                x = Convert.ToInt32(Console.ReadLine());
                if (x < 0)
                { x = -1; }
                else if (x == 0)
                { x = 0; }
                else
                { x = 1; }                
                s = s + x;
                
            }
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            float x=0, s=0;
           
            Sign(x, s);

           
            Console.ReadKey();

        }
    }
}
