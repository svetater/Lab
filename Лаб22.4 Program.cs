using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp151
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            s = File.ReadAllText("Lab22.4.txt");
            var a = new StreamWriter("Lab22.4.txt");
            int n, i, k, t, d;
            
            n = s.Length;
            d = n;

            i = 1;
            while (i < d-1)
            {
                if (s[i]==' ')
                {
                    k = 0;
                    t = i + 1;
                    while (s[t] == ' ' && t <= d)
                    {
                        t++;
                        k++;
                    }                    
                    s = s.Remove(i + 1, k);
                    d = d - k;
                }              
                i++;
            }
            a.Write(s);
            a.Close();
            Console.ReadKey();

        }
    }
}
