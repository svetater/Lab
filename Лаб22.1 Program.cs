using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleApp148
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            text = Convert.ToString(Console.ReadLine());
            File.WriteAllText("Lab22.txt", text);
            string s;
            s = File.ReadAllText("Lab22.txt");
            int n, i, p = 0, k;
            
            n = s.Length;
            k = n - 1;
            i = 0;
            while ((i < n) && p == 0)
            {
                if (s[i] == ' ')
                    p = i;
                i++;
            }
            p++;
            s = s.Substring(p,n-p); 
            File.WriteAllText("Lab22.txt", s);
    
            Console.WriteLine(File.ReadAllText("Lab22.txt"));
            Console.ReadKey();
        }
    }
}
