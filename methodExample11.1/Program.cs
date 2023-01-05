using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int gecici;
            Console.Write("Kaç Adet Sayı Girilecek ? >>>> ");
            int k = Convert.ToInt32(Console.ReadLine());

            int[] dizi = new int[k];
            for (int i = 0; i < k; i++)
            {
                Console.Write("Dizinin {0}. elemanını girin : ", i + 1);
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("******************************");
            Console.WriteLine("Oluşturulan Dizi");
            DiziYazdir(dizi);

            //////////Bubble Sort Sıralama/////////////////
            //////////www.yazilimkodlama.com///////////////

            for (int i = 0; i <= dizi.Length - 1; i++)
            {
                for (int j = 1; j <= dizi.Length - 1; j++)
                {
                    if (dizi[j - 1] > dizi[j])
                    {
                        gecici = dizi[j - 1];
                        dizi[j - 1] = dizi[j];
                        dizi[j] = gecici;
                    }
                }
                DiziYazdir(dizi);
            }
            Console.WriteLine("Dizinin Sıralı Hali");
            DiziYazdir(dizi);
            Console.ReadKey();
        }

        public static void DiziYazdir(int[] dizi)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write("{0}   ", dizi[i]);
            }
            Console.WriteLine();
            Console.WriteLine("==================================");
        }

    }

}
