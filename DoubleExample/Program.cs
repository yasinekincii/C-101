using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****ÖĞRENCİ NOT HESAPLAMA****");
            Console.WriteLine();

            string ad, soyad, numara;
            double sinav1, sinav2, sinav3, proje, ort;

            Console.WriteLine("****ÖĞRENCİ KİMLİK BİLGİLERİ****");

            Console.Write("Adınızı giriniz=");
            ad = Console.ReadLine();

            Console.Write("Soyadınızı giriniz=");
            soyad = Console.ReadLine();

            Console.Write("Numaranızı girin=");
            numara = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("****ÖĞRENCİNİN SINAV BİLGİLERİ");

            Console.Write("1. sınav sonucunu girin=");
            sinav1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("2.Sınav Sonucunu Giriniz=");
            sinav2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("3. Sınav Sonucunu Giriniz=");
            sinav3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Proje sonucunuzu giriniz=");
            proje = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine();
            Console.WriteLine("***ÖĞRENCİ ORT HESAPLAMA****");

            ort = (sinav1 + sinav2 + sinav3 + proje) / 4;
                Console.WriteLine("Öğrencinin ortalaması={0}",ort);

            Console.WriteLine("{0} {1} isimli {2} numaralı öğrencinin ortalaması={3}'dir",ad,soyad,numara,ort);

            Console.ReadLine();
        }
    }
}
