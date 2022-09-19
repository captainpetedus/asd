using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            letrehoz();
        }
        static void letrehoz()
        {
            Console.Write("Kérek egy nevet: ");
            string nev = Console.ReadLine();
            Console.WriteLine("nev");
            StreamWriter ir = new StreamWriter("osztaly.txt");
            ir.Close();
        }
    }
}
