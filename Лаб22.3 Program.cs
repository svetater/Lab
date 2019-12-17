using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp150
{
    class Program
    {
        static void Main(string[] args)
        {
            string s, s1;
            s = File.ReadAllText("Lab22.3.1.txt");
            s1 = File.ReadAllText("Lab22.3.2.txt");
            var a = new StreamWriter("Lab22.3.1.txt");
   
           
            a.Write(s1+" ");            

            a.Write(s);
            a.Close();
            Console.ReadKey();
        }
    }
}
