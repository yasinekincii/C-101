using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExample5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String ad, soyad, sehir;
            Console.WriteLine("Ad: ");
            ad = Console.ReadLine();

            Console.WriteLine("Soyadınızı girin: ");
            soyad = Console.ReadLine();

            Console.WriteLine("Şehrinizi girin");
            sehir = Console.ReadLine();

            Console.WriteLine("Ad - Soyad - Sehir {0} {1} {2}",ad, soyad, sehir);
            Console.WriteLine("Ad: {0}, Soyad: {1}, Sehir: {2}",ad,soyad,sehir);


            Console.Read();
        }
    }
}
