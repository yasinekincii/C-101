using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Background2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir sayı girin: ");
            ConsoleColor renk = (ConsoleColor)Convert.ToInt16(Console.ReadLine());
            Console.BackgroundColor = renk;

            Console.Clear();
            Console.Read();

        }
    }
}
