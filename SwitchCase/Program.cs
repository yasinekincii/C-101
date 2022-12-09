using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //switch=anahtar anahtar değerimiz sayı
            //case durum demek
            //switch case çok fazla dallanma gerektiren koşul ifadelerinde kullanılan komutlardır.
            //dallanma=1-12 arası sayıları girdiğimzde karşına o ayı yazan program
            //switch case bizi çok fazla if kullanmaktan kurtarır.

            //klavyeden girilen sayıya göre haftanın ilgili günün veren programı oluşturun.

            int sayi;
            Console.Write("1 ile 7 arasında bir sayı giriniz= ");
            sayi = Convert.ToInt16(Console.ReadLine());


            switch (sayi)
            {
                case 1:Console.Write("Gün=Pazartesi");//benden case'i kapatmamı bekliyor.Yani burayı sonlandırmamı bekliyor o yüzden break kullanıp altındaki hatayı kaldırıyoruz.
                    break;
                case 2:Console.Write("Gün=Salı");
                    break;
                case 3:Console.Write("Gün=Çarşamba");
                    break;
                case 4:Console.Write("Gün=Perşembe");
                    break;
                case 5:Console.Write("Gün Cuma");
                    break;
                case 6:Console.WriteLine("Gün cumartesi");
                    break;
                case 7:Console.Write("Gün pazar");
                    break;
                //bu durumların dışındaysa bizim girdiğimiz değer
                //7'nin dışındaysa varsayılan olarak şunu yaz:
                default: Console.Write("Hatalı Gün Girişi");
                    break;

            }
            Console.ReadLine();   
              
        
        
        }


    }
}
