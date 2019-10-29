using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp71
{
    class Program
    {
        static void Main(string[] args)
        {
            int g, k, c;
            g = Convert.ToInt32(Console.ReadLine());
            k = g % 12;
            c = g % 60-4;
            switch (c)
            {
                case 0: case 1: case 2: case 3: case 4: case 5: case 6: case 7: case 8: case 9: case 10: case 11: Console.WriteLine("Год зеленой"); break;
                case 12: case 13: case 14: case 15: case 16: case 17: case 18: case 19: case 20: case 21: case 22: case 23: Console.WriteLine("Год красной"); break;
                case 24: case 25: case 26: case 27: case 28: case 29: case 30: case 31: case 32: case 33: case 34: case 35: case 36: Console.WriteLine("Год желтой"); break;
                case 37: case 38: case 39: case 40: case 41: case 42: case 43: case 44: case 45: case 46: case 47: case 48: Console.WriteLine("Год белой"); break;
                case 49: case 50: case 51: case 52: case 53: case 54: case 55: case 56: case 57: case 58: case 59: case 60: Console.WriteLine("Год черной"); break;

            }
            switch (k)
            {
                case 4: Console.WriteLine("крысы"); break;
                case 5: Console.WriteLine("коровы"); break;
                case 6: Console.WriteLine("тигра"); break;
                case 7: Console.WriteLine("зайца"); break;
                case 8: Console.WriteLine("дракона"); break;
                case 9: Console.WriteLine("змеи"); break;
                case 10: Console.WriteLine("лошади"); break;
                case 11: Console.WriteLine("овцы"); break;
                case 0: Console.WriteLine("обезьяны"); break;
                case 1: Console.WriteLine("курицы"); break;
                case 2: Console.WriteLine("собаки"); break;
                case 3: Console.WriteLine("свиньи"); break;
            }
            Console.ReadKey();
        }
    }
}
