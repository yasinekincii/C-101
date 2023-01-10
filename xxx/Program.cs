using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Elemanları tam sayı olan bir A dizisinin(20 elemanlı) rastgele sayılar atayan, sonra dizi elemanlarının aritmetik ortalamasını hesaplayan ve elemanlardan kaç tanesinin bu ortalamadan büyük ve küçük olduğunu sayan programın c# kodlarını yazınız.

            Random rnd = new Random();  //dizinin elemanlarına rastgele değer atayabilmek için random sınıfını yazdım.

            int[] x = new int[20];      //20 elemanlı elemanları tam sayı olan bir dizi oluşturdum.
            int totalValue = 0;//elemanların toplam değeri
            double average;
            int higher = 0;
            int lower = 0;

            for (int i=0; i<x.Length; i++)
            {
                x[i] = rnd.Next(100);
                totalValue += x[i];
            }
            average = totalValue / x.Length;//elemanalrın toplam değerini eleman sayısına bölüp ortalamayı buldum.

            for (int i=0; i<x.Length;i++)
            {
                if (x[i] > average)
                {
                    higher++;
                }
                else if (x[i]<average)
                {
                    lower++;
                }
                else
                {
                    Console.WriteLine($"{x[i]} değeri ortalamaya eşittir. ");
                }
            }
            Console.WriteLine($"{higher} tane sayı ortalama değerinin üzerindedir");
            Console.WriteLine($"{lower} tane sayı ortalama değerinin altındadır.");


            Console.ReadLine();
        }
    }
}
