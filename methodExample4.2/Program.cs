using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metot_dizi_cift
{
    class Program
    {      
        static void Main(string[] args)
        {
            int[] numbers = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(0, 100);
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("======================");
            
            
            Program b = new Program();
            int buyuksayi = b.Max(numbers);
            if (buyuksayi != 0)
            {
                Console.WriteLine("Dizideki en büyük çift sayı = {0}", b.Max(numbers));
            }
            else
            {
                Console.WriteLine("Dizide çift sayı bulanamadı");
            }
                        
            Console.ReadKey();
        }


        private int Max(int[] sayilar)
        {
            int buyuk = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                if (buyuk < sayilar[i] && sayilar[i] % 2 == 0)
                { buyuk = sayilar[i]; }
            }
            return buyuk;
        }
    }
}