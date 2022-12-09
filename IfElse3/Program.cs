using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.WriteLine("Bir Sayı Giriniz");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi > 0)
            {
                Console.WriteLine("Sayı pozitiftir");
            }
            else
            {
                Console.WriteLine("Sayı negatiftir");
            }

            Console.Read();
        }
    }
}
