﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, m, s;
            Console.WriteLine("Введите числа ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if ((a > b) && (a > c))
            {
                if (b > c)
                { s = b + a; }
                else
                { s = c + a; }
            }
            else if ((b > a) && (b > c))
            {
                if (a > c)
                { s = b + a; }
                else
                { s = b + c; }
            }
            else
            {
                if (a > b)
                { s = c + a; }
                else
                { s = c + b; }
            }
            Console.WriteLine("Summa=" + s);
            Console.ReadKey();
                
            
        }
    }
}
