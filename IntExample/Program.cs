using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, toplam;

            sayi1 = 5;
            sayi2 = 7;
            toplam = sayi1 + sayi2;
            Console.Write(toplam);

            Console.Read();
            //eğer değerleri yazdırmazsam değişkenin isiminin altında yeşil çizgi olucak.
        }
    }
}
