using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden 5 tane sayı girdirelim bu aldığımız sayıları bir diziye atalım ondan sonra bu dizi içerisinde en büyük değri bulalım ve
            //bulduğumuz en büyük değeri ekrana yazdıralım

            int[] sayilar = new int[5];//dizimin boyutunu yazdım(5 eleman)

            for (int i=0; i<5; i++) 
            {
                Console.Write((i+1).ToString() + ".Sayıyı giriniz= ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            int enBuyuk;
            enBuyuk = sayilar[0];
            for (int i=0; i<5; i++) {

                if (enBuyuk < sayilar[i]) {

                    enBuyuk = sayilar[i];
                }     
                    
                        
            }
            Console.WriteLine("En büyük sayı= "+enBuyuk);

            Console.Read();
        }
    }
}
