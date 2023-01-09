using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Klavyeden girilen bir cümledeki kelime sayısını bulunuz.
            
            Console.WriteLine("Bir cümle girin: ");
            string text = Console.ReadLine();               //kullanıcıdan alınan değer text değişkenine atandı.
            int numberOfWords = 0;

            string[] words = text.Split(' ');               //kullanıcının girdiği metini boşluklar arasından ayırdı.            
            

            Console.WriteLine($"\nGirilen metindeki kelime sayısı: {words.Length}");       //sayacım dizimdeki eleman sayısını göstericek.
            #endregion


            #region Bir komisyoncu sattığı mallardan fiyatı 50 TL kadar olanlardan % 3, daha fazla olanlardan ise % 2 komisyon almaktadır. Klavyeden girilen teker teker girilen 5 malın komisyonlarını bulup ekrana yazdıran ve en sonunda da toplam komisyonu ekrana yazdıran programın kodlarını yazınız.
            

            int[] product = new int[5];
            double commission = 0;
            double totalValue = 0;

            for (int i = 0; i < product.Length; i++)
            {
                Console.Write(i + 1 + ". malın fiyatı: ");
                product[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine();
            for (int i = 0; i < product.Length; i++)
            {
                if (product[i] < 50)
                {
                    commission = product[i] * 0.03;
                    Console.WriteLine(i + 1 + ". üründen alınan komisyon: " + commission);
                    totalValue += commission;
                }
                else
                {
                    commission = product[i] * 0.02;
                    Console.WriteLine(i + 1 + ". üründen alınan komisyon: " + commission);
                    totalValue += commission;
                }
            }

            Console.WriteLine($"\nSatışlardan elde edilen toplam komisyon: {totalValue}");

            #endregion

            #region Diger cozum
            double malFiyati = 0, komisyonMiktari = 0, toplamKomisyon = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0}. Malın Fiyatını Giriniz : ", i + 1);
                malFiyati = Convert.ToDouble(Console.ReadLine());

                if (malFiyati > 50) komisyonMiktari = malFiyati * 0.02;

                else komisyonMiktari = malFiyati * 0.03;

                Console.WriteLine("{0}. Mal İçin Komisyon Miktarı : {1}", i + 1, komisyonMiktari);
                toplamKomisyon += komisyonMiktari;
            }
            Console.WriteLine("Toplam Komisyon Miktarı : {0}", toplamKomisyon);

            #endregion

            #region Kullanıcı tarafından girilen üç sayıdan en büyük ile en küçük sayıyı toplayıp toplam sonucu ekrana yazdıran programı yazınız.

            //Kullanıcı tarafından girilen üç sayıdan en büyük ile en küçük sayıyı toplayıp toplam sonucu ekrana yazdıran programı yazınız.

            decimal[] numbers = new decimal[5];

            decimal minValue = decimal.MinValue;
            decimal HighestValue = decimal.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write((i + 1) + ". Değeri giriniz: ");
                numbers[i] = Convert.ToDecimal(Console.ReadLine());

                if (numbers[i] < HighestValue)
                {
                    HighestValue = numbers[i];
                }
                if (numbers[i] > minValue)
                {
                    minValue = numbers[i];
                }
            }

            Console.Clear();
            System.Threading.Thread.Sleep(3000);

            Console.WriteLine($"\nen büyük sayı: {minValue}, en küçük sayı: {HighestValue} ");
            Console.WriteLine();
                      

            #endregion
        }
    }
}
