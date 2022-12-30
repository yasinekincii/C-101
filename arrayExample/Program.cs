using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int veri tipinde bir dizi oluşturalım, kullanıcımız dizinin kaç elemanlı olacağı
             * bilgisini bize versin ve dizi içindeki alanlara değer ataması yapsın.Daha sonra
             * dizi içerisindeki elemanların toplamlarını ve ortalamasını ekrana yazdıran bir
             * uygulama yazalım.
             */

            Console.Write("Sınıf mevcudunu giriniz: ");
            int mevcut = Convert.ToInt32(Console.ReadLine());

            int[] sinavNotlari = new int[mevcut];

            Console.WriteLine("Sınıfımızdaki öğrencilerin sınav notlarını giriniz");
            for (int i = 0; i < mevcut; i++)
            {
                Console.WriteLine(i + 1 + ".kişinin sınav notunu giriniz ");
                sinavNotlari[i] = Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine("Sınıfımızdaki notlar");
            int toplam = 0;
            for (int i = 0; i < mevcut; i++)
            {
                Console.WriteLine(sinavNotlari[i]);
                toplam += sinavNotlari[i];
            }

            Console.WriteLine("Dizi içerisindeki elemanların toplamı= " + toplam);

            Console.WriteLine("Dizi içerisindeki elemanların ortalaması= " + (toplam / mevcut));

            Console.ReadLine();
        }
    }
}
