using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodExample4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bu örneğimizde C# ile 20 elemanlı bir diziye 0-100 arası rastgele sayılar atarak bu dizi içinde bulunan en büyük çift sayıyı metot kullanarak bulacağız. Değer girme ve dizi elemanlarını yazdırma işlemini ana programda, en büyük çift sayıyı bulma işlemini metot kullanarak gerçekleştireceğiz.Örneğimizde rastgele girişi yapılan sayılardan hiçbirinin çift olmaması durumunda “Dizide çift sayı bulunamadı” mesajı verilmesi sağlanmıştır. C# kodlarımız aşağıdaki gibi olacaktır.

            Random R = new Random();
            int[] numbers = new int[20];


            Console.WriteLine("\nDizimizin Elemanları: \n");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = R.Next(101);
                Console.WriteLine(i + 1 + ". eleman = " + numbers[i]);
            }

            Console.WriteLine("\n\n");
            enBuyukCiftSayi(numbers);


            Console.ReadLine();
        }


        static void enBuyukCiftSayi(params int[] sayilar)
        {
            int enBuyukCiftSayi = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] % 2 == 0)
                {
                    if (sayilar[i] > enBuyukCiftSayi)
                    {
                        enBuyukCiftSayi = sayilar[i];
                    }
                }
            }
            if (enBuyukCiftSayi == 0)
            {
                Console.WriteLine("Dizimizde çift sayi bulunmamaktadır.");
            }
            else
            {
                Console.WriteLine("Dizinin en büyük çift sayısı: {0}", enBuyukCiftSayi);

            }

        }
    }
}
