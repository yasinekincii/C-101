using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sinav1, sinav2, proje, ortalama;
            
            Console.Write("1. SInavı giriniz=");
            sinav1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. sınavı giriniz=");
            sinav2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Proje notunuzu giriniz=");
            proje = Convert.ToInt32(Console.ReadLine());

            ortalama = (sinav1+sinav2+proje)/3;
            Console.WriteLine("Ortalama değeri"+ortalama);

            if (ortalama >= 0 && ortalama < 30) {
                Console.WriteLine("Durum: Çok Kötü");
            } else if (ortalama >= 30 && ortalama < 50) {
                Console.WriteLine("Ortalama iyi değil");
            } else if (ortalama >= 50 && ortalama < 75) {
                Console.WriteLine("Durum: İyi");
            } else if (ortalama>=75 && ortalama<90) {
                Console.WriteLine("Durum: çok iyi");
            }else if(ortalama>=90 && ortalama <= 100) {
                Console.WriteLine("Durum: Harika!!");
            }
            else {
                Console.WriteLine("Hatalı giriş yaptınız tekrar deneyiniz");
            }

            Console.ReadLine();
        }
    }
}
