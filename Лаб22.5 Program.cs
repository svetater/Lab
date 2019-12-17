using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp153
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            s = File.ReadAllText("Lab22.5.txt");
            int n, i = 0;
            n = s.Length;
            int k = 0, t = 0;
            while (i < n -1)
            {
                while ((s[i] == ' ') && (i < n ))
                {
                    k++;
                    i++;
          
                }
                if (k == 5)
                    t++;
               
                k = 0;
                while ((s[i] != ' ') && (i < (n - 1)))
                {
                    i++;
                    
                }
              
            }
            Console.WriteLine(t);
            Console.ReadKey();

        }
    }
}
