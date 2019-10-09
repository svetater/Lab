using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, p1, p2, k;
            Console.WriteLine("Введите числа");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            p1 = a / c;
            p2 = b / c;
            k = p1 * p2;
            Console.WriteLine("Количество квадратов: " + k);
            Console.ReadKey();
        }
    }
}
