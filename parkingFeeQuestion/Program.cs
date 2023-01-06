using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkingFeeQuestion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir otoparka park eden taksinin 1 saati 5TL, minibüsün 1 saati 6TL, ticari aracın 1 saati 6.5TL dir. Taksi 1 saatten sonraki her saat başı için %20 daha fazla, minibüs 1 saatten sonraki her saat başı için toplamda %21.5 ve ticari araç 1 saatten sonraki her saat başı için toplamda %25 daha fazla ödeme yapmaktadır. Buna göre klavyeden girilen araba tipi ve kalınan saat bilgisi girildikten sonra ekrana ödenecek otopark ücretini hesaplayan programın kodlarını yazınız.

            string typeOfCar;
            int parkingTime;
            Class2 C2 = new Class2();

            
            Console.Write("Araba Tipini Giriniz: ");
            typeOfCar = Console.ReadLine();
            

            Console.Write("Otoparkta kalma süresini giriniz: ");
            parkingTime = Convert.ToInt32(Console.ReadLine());

            Deneme(typeOfCar, parkingTime);            
        }



        static void Deneme(string typeOfCar,int parkingTime)
        {
            Class2 C3 = new Class2();
            typeOfCar = typeOfCar.ToLower();

            if (typeOfCar == "taksi")
            {
                Taksi(parkingTime);
            }
            else if (typeOfCar == "minibüs")
            {
                C3.Minibus(parkingTime);
            }
            else if (typeOfCar == "ticariarac")
            {
                C3.TicariArac(parkingTime);
            }
            else
            {
                Console.WriteLine("Hatalı bir giriş yaptınız tekrar deneyiniz..");
                
            }

        }


        

        static void Taksi(double saat)
        {
            //taksinin 1 saatlik ücreti 5tl 1 saatten sonraki her saat başı için %20 daha fazla
            double price = 5;            

            if (saat<=1&&saat>0)
            {
                
            }
            else if (saat>1)
            {
                for (int i=2; i<=saat;i++)
                {
                    price = price * 1.2;
                }
                Console.WriteLine($"Otopark icretiniz: {price}");
            }
            else
            {
                Console.WriteLine("Hatalı bir giriş yaptınız tekrar deneyiniz..");
            }

        }
    }
}
