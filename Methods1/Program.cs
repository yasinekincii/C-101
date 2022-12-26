using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods1
{
    internal class Program
    {
        static void Main(string[] args)//main metodu
        {
            //Sonunda aç kapa bir parantez gördüğünde bu bir metottur
            //metotlar sınıf içerisinde yer alırlar ve metodun dışarısında tanımlanırlar.
            //metot içinde metot tanımlaması olmuyor.

            //metodu class program sınıfının içerisinde tanımlıyoruz.


            Yaz("Merhaba!");


            var result = Sum(5,4);
            Yaz(result.ToString());
            Bosluk();
            Yaz(Sum(10,10).ToString());


            Yaz(GetAccountName(2));


            var sonuc=IsValid("yasin.ekinci@hotmail.com");
            Yaz(sonuc.ToString());

            Beklet();//beklet metodunu burada çağırıyorum readLine()'ın yaptığı işi yapıcak.
        }

        static bool IsValid(string email)
        {
            bool isValid= default(bool);

            if (email.Contains("@"))
            {
                isValid = true;
            }

            return isValid; 
              
        }

        static string GetAccountName(int accountID)
        {
            string accountName = string.Empty;

            switch (accountID)
            {
                case 1:
                    accountName = "Yasin";
                    break;
                case 2:
                    accountName = "Hayriye";
                    break;
                case 3:
                    accountName = "Mustafa";
                    break;
                case 4:
                    accountName = "Sena";
                    break;

                default:
                    accountName = "Unknown";
                    break;
            }

            return accountName;


        }

        static void Bosluklu(int sayi)
        {
            for (int i=0; i<sayi; i++)
            {
                Console.WriteLine();//Bu şekilde girdiğim sayi kadar boşluk bırakıcak
            }
        }

        static void Bosluk()
        {
            Console.WriteLine(Environment.NewLine);//alt satıra indirme işlemi var
        }

        static int Sum(int number1,int number2)
        {
            return number1 + number2;
        }

        static double Sum(double number1,double number2)//BU METOTLARIN AŞIRI YÜKLENMESİDİR.
        {
            return number1 + number2;
        }

        //bir tane bir metot adımız var.Bu metottan birden fazla varsa bu metot aşırı yüklenmiş demektir.


        static void Yaz(string text)
        {
            Console.WriteLine(text);
        }

        static void Beklet()
        {
            //beklet metodumuzun adı
            //void bu metodun geri dönüş tipi
            //bu metod geriye hiçbir şey döndürmeyecekse void olur
            Console.ReadLine();
        }
    }
}
