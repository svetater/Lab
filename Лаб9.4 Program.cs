using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp70
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            int a1, a2, a3;
            a1 = a / 100;
            switch(a1)
            {
                case 1: Console.WriteLine("Сто"); break;
                case 2: Console.WriteLine("Двести"); break;
                case 3: Console.WriteLine("Триста"); break;
                case 4: Console.WriteLine("Четыреста"); break;
                case 5: Console.WriteLine("Пятьсот"); break;
                case 6: Console.WriteLine("Шестьсот"); break;
                case 7: Console.WriteLine("Семьсот"); break;
                case 8: Console.WriteLine("Восемьсот"); break;
                case 9: Console.WriteLine("Девятьсот"); break;              
            }
            a2 = (a % 100) / 10;
            switch (a2)
            {
                case 1:
                    a3 = a % 10;
                    switch (a3)
                    {
                        case 0: Console.WriteLine("десять"); break;
                        case 1: Console.WriteLine("одиннадцать"); break;
                        case 2: Console.WriteLine("двенадцать"); break;
                        case 3: Console.WriteLine("тринадцат"); break;
                        case 4: Console.WriteLine("четырнадцать"); break;
                        case 5: Console.WriteLine("пятнадцать"); break;
                        case 6: Console.WriteLine("шестнадцать"); break;
                        case 7: Console.WriteLine("семнадцать"); break;
                        case 8: Console.WriteLine("восемнадцать"); break;
                        case 9: Console.WriteLine("девятнадцать"); break;
                    }
                    break;
                case 2: Console.WriteLine("двадцать"); break;
                case 3: Console.WriteLine("тридцать"); break;
                case 4: Console.WriteLine("сорок"); break;
                case 5: Console.WriteLine("пятьдесят"); break;
                case 6: Console.WriteLine("шестьдесят"); break;
                case 7: Console.WriteLine("семьдесят"); break;
                case 8: Console.WriteLine("восемьдесят"); break;
                case 9: Console.WriteLine("девяносто"); break;
            }
            if (a2 != 1)
            {
                a3 = a % 10;
                switch (a3)
                {
                    case 1: Console.WriteLine("один"); break;
                    case 2: Console.WriteLine("два"); break;
                    case 3: Console.WriteLine("три"); break;
                    case 4: Console.WriteLine("четыре"); break;
                    case 5: Console.WriteLine("пять"); break;
                    case 6: Console.WriteLine("шесть"); break;
                    case 7: Console.WriteLine("семь"); break;
                    case 8: Console.WriteLine("восемь"); break;
                    case 9: Console.WriteLine("девять"); break;
                }
            }
            Console.ReadKey();
        }
    }
}
