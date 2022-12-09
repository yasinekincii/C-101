using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mevsim;
            Console.WriteLine("Bir mevsim giriniz");
            mevsim = Console.ReadLine();

            if (mevsim == "kış")
            {
                Console.WriteLine("Kış Mevsimi Ayları:Aralık, Ocak, Şubat");
            }else if (mevsim == "ilkbahar")
            {
                Console.WriteLine("İlkbahar Mevsimi Ayları:Mart, Nisan, Mayıs");
            }else if (mevsim == "yaz")
            {
                Console.WriteLine("Yaz Mevsimi Ayları:Haziran, Temmuz, Ağustos");
            }else if (mevsim=="sonbahar") {
                Console.WriteLine("Sonbahar Mevsimi Ayları:Eylül, Ekim, Kasım");
            }
            else
            {
                Console.WriteLine("Hatalı mevsim girişi yaptınız.Tekrar deneyiniz");
            }

            Console.Read();
        }
    }
}
