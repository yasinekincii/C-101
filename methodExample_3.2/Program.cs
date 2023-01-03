using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int sayac = 0;
            Console.Write("Sayıyı Girin : ");
            int s = Convert.ToInt32(Console.ReadLine());

            if (asalmi(s))
            {
                Console.WriteLine("{0} sayısı Asal", s);
            }
            else
            {
                Console.WriteLine("{0} sayısı asal değil", s);
            }

            Console.WriteLine("===========================");
            Console.WriteLine("Sonraki 5 Asal Sayı");
            Console.WriteLine("===========================");

            while (true)
            {
                s++;
                if (asalmi(s) == true)
                {
                    Console.WriteLine("{0} sayısı asal", s);
                    sayac++;
                    if (sayac == 5)
                    {
                        break;
                    }
                }
            }
            Console.ReadKey();
        }


        public static bool asalmi(int sayi)
        {
            bool durum = false;

            int kontrol = 0;

            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    kontrol = 1;
                    break;
                }
            }
            if (kontrol == 1)
            {
                durum = false;
            }
            else
            {
                durum = true;
            }

            return durum;
        }
    }
}