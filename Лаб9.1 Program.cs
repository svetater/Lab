using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp67
{
    class Program
    {
        static void Main(string[] args)
        {
            int d, m;
            d = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            switch (d)
            {
                case 1: Console.WriteLine("первое"); break;
                case 2: Console.WriteLine("второе"); break; 
                case 3: Console.WriteLine("третье"); break;
                case 4: Console.WriteLine("четвертое"); break; 
                case 5: Console.WriteLine("пятое"); break;
                case 6: Console.WriteLine("шестое"); break; 
                case 7: Console.WriteLine("седьмое"); break;
                case 8: Console.WriteLine("восьмое"); break; 
                case 9: Console.WriteLine("девятое"); break;
                case 10: Console.WriteLine("десятое"); break; 
                case 11: Console.WriteLine("одиннадцатое"); break;
                case 12: Console.WriteLine("двенадцатое"); break; 
                case 13: Console.WriteLine("тринадцатое"); break;
                case 14: Console.WriteLine("четырнадцатое"); break; 
                case 15: Console.WriteLine("пятнадцатое"); break;
                case 16: Console.WriteLine("шестнадцатое"); break; 
                case 17: Console.WriteLine("семнадцатое"); break;
                case 18: Console.WriteLine("восемнадцатое"); break; 
                case 19: Console.WriteLine("девятнадцатое"); break;
                case 20: Console.WriteLine("двадцатое"); break; 
                case 21: Console.WriteLine("двадцать первое"); break; 
                case 22: Console.WriteLine("двадцать второе"); break;
                case 23: Console.WriteLine("двадцать третье"); break; 
                case 24: Console.WriteLine("двадцать четвертое"); break;
                case 25: Console.WriteLine("двадцать пятое"); break; 
                case 26: Console.WriteLine("двадцать шестое"); break;                  
                case 27: Console.WriteLine("двадцать седьмое"); break; 
                case 28: Console.WriteLine("двадцать восьмое"); break;
                case 29: Console.WriteLine("двадцать девятое"); break; 
                case 30: Console.WriteLine("тридцатое"); break;
                case 31: Console.WriteLine("тридцать первое"); break;
            }
            switch(m)
            {
                case 1: Console.WriteLine(" января"); break;
                case 2: Console.WriteLine(" февраля"); break;
                case 3: Console.WriteLine(" марта"); break;
                case 4: Console.WriteLine(" апреля"); break;
                case 5: Console.WriteLine(" мая"); break;
                case 6: Console.WriteLine(" июня"); break;
                case 7: Console.WriteLine(" июля"); break;
                case 8: Console.WriteLine(" августа"); break;
                case 9: Console.WriteLine(" сентября"); break;
                case 10: Console.WriteLine(" октября"); break;
                case 11: Console.WriteLine(" ноября"); break;
                case 12: Console.WriteLine(" декабря"); break;
            }
            Console.ReadKey();
        }
    }
}
