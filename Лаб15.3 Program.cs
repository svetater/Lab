﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp96
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, h = 1;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (i = 0; i < n; i++)
                a[i] = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
                if ((a[i] % 2) == 0)
                    h = a[i];
            if (h == 1)
            {
                for (i = 0; i < n; i++)
                    Console.WriteLine("a[" + i + "]=" + a[i]);
            }
            else
            {
                for (i = 0; i < n; i++)
                {
                    if ((a[i] % 2) == 0)
                        a[i] = a[i] + h;
                    Console.WriteLine("a[" + i + "]=" + a[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
