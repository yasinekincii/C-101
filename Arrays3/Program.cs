using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bir sınıf düşünün bu sınıfta 3 tane eleman var(öğrenci) bu öğrencilerin sırasıyla adını 1. sınavını 2 sınavını ve ort klavyeden giricez sonra bunları bellekte tutucaz dizi değerim ğst sınıra ulaştığında bunları listeleticez

            string[] isim = new string[3];
            int[] s1 = new int[3];
            int[] s2 = new int[3];
            int[] ort = new int[3];

            for(int i =0; i<3; i++)
            {
                Console.Clear();//1. döngü tamamlandığı zaman ekran silinicek

                Console.Write((i + 1) + " Öğrencinin Adı: ");
                isim[i] = Console.ReadLine();

                Console.Write((i+1) + ".Sınav1: ");
                s1[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write((i+1) + ".Sınav2 ");
                s2[i] = Convert.ToInt32(Console.ReadLine());

                ort[i] = (s1[i] + s2[i]) / 2;

            }
            //Console.Write("Öğrenci  Sınav  Sınav2  Ortalama");
            Console.WriteLine();

            for(int i=0; i<3; i++)
            {
                //Console.WriteLine(" " + isim[i] + " " + s1[i] +" " + s2[i]+" " + ort[i]);
                Console.WriteLine("Öğrencinin adı= {0}, 1.sınavı= {1}, 2.Sınavı= {2}, ortalaması= {3}", isim[i], s1[i], s2[i], ort[i]);
            }


            Console.Read();
        }
    }
}
