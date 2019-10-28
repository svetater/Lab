using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            if (a!=0)
            {
                if (a < 0) Console.WriteLine("Отрицательное ");
                else Console.WriteLine("Неотрицательное ");
                if ((a % 2) == 0) Console.WriteLine("четное число");
                else Console.WriteLine("нечетное число");
            }
            else
            {
                Console.WriteLine("Нулевое число");
            }
            Console.ReadKey();
        }
    }
}
