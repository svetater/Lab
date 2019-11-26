using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp90
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, k=0;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (i=0;i<n;i++)
            { a[i]= Convert.ToInt32(Console.ReadLine()); }
            for (i=0;i<n-2;i++)
            {
                if ((a[i+1]-a[i])==(a[i+2]-a[i+1]))
                { k++;}
            }
            if (k==n-2)
            { Console.WriteLine("Raznost=" + (a[2] - a[1])); }
            else
            { Console.WriteLine("0"); }
            Console.ReadKey();  
        }
    }
}
