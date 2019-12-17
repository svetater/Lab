using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp149
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int n, k, i, j;
            name = Convert.ToString(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            k = Convert.ToInt32(Console.ReadLine());
            var a = new StreamWriter(name, true);
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < k; j++)
                    a.Write("*");
                a.WriteLine();
            }
            a.Close();       
            
            Console.ReadKey();
        }
    }
}
