using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Matematiksel işlemler

            Mathematics M = new Mathematics();

            YenidenIslemYap:

            M.menu();
            int choose = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen 1. Sayı değerini Giriniz: ");
            decimal kullaniciSayi1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 2.sayı değerini Giriniz: ");
            decimal kullaniciSayi2 = decimal.Parse(Console.ReadLine());

            decimal sonuc = 0;

            switch (choose)
            {
                case 1:   //toplama
                    sonuc = M.sum(kullaniciSayi1, kullaniciSayi2); //toplama işlemi nerede? M olarak isimlendirmiş olduğum mathematics classımın içerisindeki(noktaya bastım= M.) . operatörü classın yanına konduğunda onun içindeki metotları bana listeletir.
                    M.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "+");
                        break;

                case 2://çıkartma
                    sonuc = M.minus(kullaniciSayi1, kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "-");
                    break;

                case 3://çarpma
                    sonuc = M.muplication(kullaniciSayi1,kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1,kullaniciSayi2,sonuc,"*");
                    break;

                case 4://bölme işlemi
                    sonuc = M.divide(kullaniciSayi1,kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1,kullaniciSayi2,sonuc,"/");
                    break;


                default:
                    Console.WriteLine("Belirtmiş olduğunuz değer liste içerisinde bulunamadı.\nYeniden deneyiniz");
                    System.Threading.Thread.Sleep(2000);//2 saniye sistemi beklettim.
                    goto YenidenIslemYap;//yeniden işlem yapa gidicek
                    break;
            }

            Console.WriteLine("Yeni bir işlem yapmak istiyor musunuz? [E/H]");
            string EH = Console.ReadLine();
            EH = EH.ToLower();
            if (EH == "e")
            {
                goto YenidenIslemYap; 
            }

        }
    }
}
