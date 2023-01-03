using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodExample_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bu yazımızda C# ile bir sayının asal olup olmadığını Metot kullanarak bulan bir örnek gerçekleştireceğiz. Örneğimizde kullanıcının girdiği sayının asal olup olmadığını ekranda yazdıracağız ve bu sayıdan sonraki 5 tane asal sayının hangisi olduğunu bularak yazdıracağız.

            asalMi(5);

            Console.ReadLine();
        }

        static void asalMi(int sayi)
        {
            int sayac = 0;

            if (sayi > 2)
            {
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        sayac++;
                    }
                }
            }
            else if (sayi == 2)
            {
                sayac = 0;
            }
            else if (sayi < 2)
            {
                sayac++;
            }


            if (sayac > 0 || sayac < 0)
            {
                Console.WriteLine("Girilen {0} sayısı asal değildir",sayi);
            }
            else
            {
                Console.WriteLine("Girilen {0} sayısı asaldır.",sayi);
            }

            asalSayilariBulma(sayi);

        }

        static void asalSayilariBulma(int s)
        {
            Console.WriteLine("***\nSonraki 5 asal sayi\n***");

            int asalSayiSayac = 0;
            int sayac = 0;

            int[] x = new int[4];

            do
            {
                s += 1;
                sayac = 0;
                if (s > 2)
                {
                    for (int i = 2; i < s; i++)
                    {
                        if (s % i == 0)
                        {
                            sayac++;
                        }
                    }
                }
                else if (s == 2)
                {
                    sayac = 0;

                }
                else
                {
                    sayac++;
                }

                if (sayac == 0)
                {
                    Console.WriteLine(s + " Sayısı asaldır.");
                    asalSayiSayac++;


                }
            } while (asalSayiSayac < 5);

        }


    }
}
