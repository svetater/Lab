using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите число");
            a = Convert.ToInt32(Console.ReadLine());
            if (((a%2)==0)&&(a<100)&&(a>9))
            { Console.WriteLine("True"); }
            else
            { Console.WriteLine("False"); }
            Console.ReadKey();
        }
    }
}
