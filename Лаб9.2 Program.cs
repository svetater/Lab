using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp68
{
    class Program
    {
        static void Main(string[] args)
        {
            string c;
            int n;
            c = Convert.ToString(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            if (c == "С")
            {
                switch (n)
                {
                    case 1: Console.WriteLine("Восток"); break;
                    case 0: Console.WriteLine("Север"); break;
                    case -1: Console.WriteLine("Запад"); break;
                }
            }
            if (c == "В")
            {
                switch (n)
                {
                    case 1: Console.WriteLine("Юг"); break;
                    case 0: Console.WriteLine("Восток"); break;
                    case -1: Console.WriteLine("Запад"); break;
                }
            }
            if (c == "З")
            {
                switch (n)
                {
                    case 1: Console.WriteLine("Север"); break;
                    case 0: Console.WriteLine("Запад"); break;
                    case -1: Console.WriteLine("Юг"); break;
                }
            }
            if (c == "Ю")
            {
                switch (n)
                {
                    case 1: Console.WriteLine("Запад"); break;
                    case 0: Console.WriteLine("Юг"); break;
                    case -1: Console.WriteLine("Восток"); break;
                }
            }
            Console.ReadKey();
        }
    }
}
