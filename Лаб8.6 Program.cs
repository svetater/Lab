using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp52
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            if ((a/100)!=0)
            { Console.WriteLine("Трехзначное"); }
            else if ((a/10)!=0)
            { Console.WriteLine("Двузначное"); }
            else
            { Console.WriteLine("Однозначное"); }
            if ((a%2)==0)
            { Console.WriteLine("четное число"); }
            else
            { Console.WriteLine("нечетное число"); }
            Console.ReadKey();
        }
    }
}
