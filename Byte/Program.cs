using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Byte
{
    internal class Program
    {
        static void Main(string[] args)
        {

            byte number;//byte 0 ile 256 arası çalışır.
            number = 255;
            Console.WriteLine(number);


            sbyte number2;//byte ile aynı miktarda değer alıyor.Fakat -128+127 aralığında
            number2 = -12;
            Console.WriteLine(number2);


            Console.WriteLine("**** Doğu Anadolu Bölgesi Hava Durumu****");
            Console.WriteLine("1-Ocak 2016 Hava Tahminleri \n");
            sbyte Erzurum, Malatya, Elazig;
            Erzurum = -35;
            Malatya = 3;
            Elazig = -7;

            Console.WriteLine("Erzurum karlı {0} Derecedir. \nMalatya çok bulutlu {1} derecedir. \nElazığ karla karışık yağmurlu {2} derecedir",Erzurum,Malatya,Elazig);







            Console.ReadLine();
        }
    }
}
