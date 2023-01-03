using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba Dünya");
            Console.WriteLine(true);

            topla(sayi1: 3, sayi2:4);
            //yazmış olduğumuz metotların parametre adetleri ya da parametre tipleri değişebilir
            //bu değişkenlikler aynı geri dönüş tipine ve aynı metot adına sahipse uygulama içerisinde bu şekilde aşırı yüklenme ile karşınıza çıkar

            Console.ReadLine();
        }

        static void topla(int sayi1,int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);
        }

        static void topla(decimal sayi1,decimal sayi2)
        {
            decimal toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);
        }

        static void topla(string metin1,string metin2)
        {
            Console.WriteLine(metin1+" "+metin2);

        }
    }
}
