using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace And
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mantıksal ve operatörü &&
            //bool donenDeger=  degisken1=="admin" && degisken2=="123"

            string kullaniciAdi = "admin6";
            string sifre = "123";
            string anahtar = "1";

            bool donenDeger = kullaniciAdi == "admin" && sifre == "123";
            bool donenDeger2 = kullaniciAdi == "admin6" && sifre == "123"&&anahtar=="1";



            //Veya Mantıksal Operatörü  ||

            string anahtar2 = "abcd";
            bool geriDonus = anahtar2 == "123" || anahtar2 == "abcd" || anahtar2 == "1";


        }
    }
}
