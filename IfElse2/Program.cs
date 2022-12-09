using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sehir;

            Console.WriteLine("Türkiye'nin başkenti neresidir=");
            sehir = Console.ReadLine();

            if (sehir == "Ankara") {
                Console.WriteLine("Doğru girdiniz!!!");
            }
            else{
                Console.WriteLine("Hatalı giriş yaptınız");
            }

            Console.Read();
        }
    }
}
