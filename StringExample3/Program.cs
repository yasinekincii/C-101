using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExample3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tek satırda birden fazla değişken tanımlayabilirsiniz.
            //Birbirinden farklı değişkenler tanımlamak için değişkenlerin arasına virgül koymanız gerekiyor.
            string ad, soyad, yas, meslek, sehir;
            //kullanıcı tarafından klavye ile girilmesini istedik

            Console.WriteLine("Lütfen ad,soyad,yas,meslek ve şehir değerlerini sırasıyla giriniz");

            ad = Console.ReadLine();
            soyad = Console.ReadLine();
            yas = Console.ReadLine();
            meslek = Console.ReadLine();
            sehir = Console.ReadLine();

            Console.WriteLine("İsim: "+ad);
            Console.WriteLine("Soyad: "+soyad);
            Console.WriteLine("Yas"+yas);
            Console.WriteLine("meslek: "+meslek);
            Console.WriteLine("sehir: "+sehir);

            Console.Read();
        }
    }
}
