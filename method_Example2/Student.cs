using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_Example2
{
    public class Student
    {
        public void ogrenciNotHesapla(string ad, string soyad, decimal not1, decimal not2, decimal not3=45)//not3=45 yaparak(opsiyonel parametre kullanıyoruz) şunu demiş oluyoruz not3'ün değeri girilmeyebilir.Eğer not3'ün değeri girilmezse default olarak 45 değeri alsın
        {
            Console.WriteLine("Öğrencinin bilgileri aşağıdaki gibidir.");
            Console.WriteLine("Ad Soyad     :{0} {1}",ad,soyad);

            //decimal ortalama = (not1 + not2 + not3) / 3;
            decimal ortalama = ortalamaHesapla(not1, not2, not3);

            //if (ortalama < 45)
            //{
            //    Console.WriteLine("Ortalama değeriniz:  {0}-Kaldınız", ortalama);
            //}
            //else
            //{
            //    Console.WriteLine("Ortalama değeriniz:  {0}-Geçtiniz", ortalama);
            //}
            
            ortalamaNotDegerlendir(ortalama);
            ortalamaNotDegerlendir(ortalamaHesapla(not1, not2, not3));//bu da yukarıdaki ortalamaNotDegerlendir metodu ile aynı sonucu vericek ama ortalama değişkeninden kurtulup iç içe metot yazmış olduk
            //iç içe kullanımlarda iç metod önce çalışır değer gönderir dış metot devam eder.
        }



        //Eğer public veya private ya da başka bir belirleyici belirtmezseniz .netflamework burada defult olarak ilgili metodu private atar
        void ortalamaNotDegerlendir(decimal ogrenciOrtalama)//parametrelerin isimleri ilgili metodun içeriğini bağlar dış taraf da ilgili metodun parametresinin veri tipine bakılır
        {
            if (ogrenciOrtalama < 45)
            {
                Console.WriteLine("Ortalama değeriniz:  {0}-Kaldınız", ogrenciOrtalama);
            }
            else
            {
                Console.WriteLine("Ortalama değeriniz:  {0}-Geçtiniz", ogrenciOrtalama);
            }
        }


        private decimal ortalamaHesapla(decimal n1,decimal n2,decimal n3)     //private olunca sadece bu class içerisinde  erişilebilir olucak dış dünyaya kapalı bir metot hazırlayacağım
        {
            //private olarak yazdığımız için mainde ortalamaHesapla metodunu göremeyiz.

            decimal ortalama = (n1 + n2 + n3) / 3;
            return ortalama;

            //bunun yerine
            //return (n1 + n2 + n3) / 3;  yazılabilirdi.
        }
    }
}
