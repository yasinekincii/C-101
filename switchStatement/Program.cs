using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //daha çok kullanıcı seçimlerinde ya da tek bir değişken üzerindeki değerlere göre işlem yapmak istediğimizde biraz daha sade olarak karar yapısı kullanmak istediğimizde
            //seçmiş olduğumuz yapı switchdir.
            /*
             * switch(ifade){
             * 
             * case kontrol1:
             * çalışacak olan işlemler
             * break;
             * 
             * case kontrol2:
             * çalışacak olan işlemler
             * break;
             * 
             * default:
             * Çalışacak olan işlemler
             * break;
             * 
             * }
             */

            Console.WriteLine("Hangi ay: ");
            string kullaniciGelen = Console.ReadLine();

            switch (kullaniciGelen.ToLower())
            {
                case "ocak":
                case "nisan":
                    Console.WriteLine("01");
                    break;

                case "şubat":
                    Console.WriteLine("02");
                    break;

                case "mart":
                    Console.WriteLine("03");
                    break;

                default:
                    Console.WriteLine("Belirtilen değerlerin dışında bir değer girişi yaptınız.");
                    break;
            }



        }
    }
}
