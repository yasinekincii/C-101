using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan herhangi bir mevsim değeri girmesini isteyelim.Kullanıcının girmiş old mevsime göre o mevsimin aylarını kullanıcıya getir.

            string mevsim;
            Console.WriteLine("Lütfen mevsimi küçük harflerle giriniz");
            mevsim = Console.ReadLine();

            switch (mevsim) { //işlem yapacağım anahtar alan mevsim

                case "yaz": Console.WriteLine("Yaz Mevsimi Ayları: haziran, temmuz, Ağustos");
                    break;
                case "sonbahar": Console.WriteLine("Sonbahar Mevsimi Ayları: Eylül, Ekim, Kasım");
                    break;
                case "kış": Console.WriteLine("Kış Mevsimi Ayları: Aralık, Ocak, Şubat");
                    break;
                case "ilkbahar": Console.WriteLine("İlkbahar mevsimi ayları: Mart,Nisan, Mayıs");
                    break;

                default:Console.WriteLine("Hatalı bir mevsim girdiniz");
                    break;
            
            }
            Console.ReadLine();
        }
    }
}
