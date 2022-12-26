using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var result=Highest(1,2,3,4,5);//overloadlarda Metodun adını yazdıktan sonra parantez içerisinde aşağı yukarı yapabiliyorsun.Kaç tane parametreli olanı seçmek istersen
            Console.WriteLine(result);


            Console.WriteLine(Rastgele().ToString());


            KullaniciEkle("yasin","ekinci");
            KullaniciEkle("Elif","Ekinci",false);//opsiyonel olmasına rağmen bu şekilde false yazığ isactive değerini değiştirebiliyorum
            Console.WriteLine("\n");

            Team(//isimlendirerek değer veridğimiz için istediğimiz sırada yazabiliriz
                oynar: false,
                ad:"yasin",
                soyad:"ekinci",
                aktifMi:false
                                
                );

            Console.ReadLine();
        }

        //İsimlendirilmiş parametreler(Named parameters)
        static void Team(string ad,string soyad,bool aktifMi=true,bool oynar=true)
        {
            Console.WriteLine("Ad:"+ad+"\nSoyad:"+soyad+"\nAktif:"+aktifMi+"\nOynar:"+oynar);
        }

        //opsiyonel parametreler
        static void KullaniciEkle(string name,string lastname,bool isActive=true)//eşittir true diyerek sen opsiyonelsin olmak zoruda değilsin demiş olduk
        {
            //opsiyonel parametreler parametrelerin en sağında yer alır
            Console.WriteLine("Ad: "+name+"\nSoyad: "+lastname+"\nAktif: "+isActive);
        }

        static int Rastgele()
        {
            Random rnd = new Random();

            return rnd.Next(1000, int.MaxValue);
        }

        static int Highest(int number1,int number2)//2 parametreli gönderirsem buraya gitsin
        {
            if (number1>number2) {
                return number1;            
            }
            else
            {
                return number2;
            }
        }

        static int Highest(int number1,int number2,int number3)//3 parametreli gönderirsem buraya gitsin
        {
            return Highest(Highest(number1,number2), number3);
        }

        //3'ten fazla ve belirsiz parametre kullanmak istersem kullanacağım metot
        static int Highest(params int[] numbers)
        { //int dizisi alıcaksın diyorum parametre olarak ama başına params koyuyorum

            int sum = 0;
            foreach (var sayi in numbers)
            {
                sum += sayi;
            }

            return sum;

        }
    }
}
