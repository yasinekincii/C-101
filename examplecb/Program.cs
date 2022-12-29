using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace examplecb
{
    internal class Program
    {  

        static void Main(string[] args)
        {
            //Tersi kendisiyle aynı olan metinlere palindrom denilir.Mesela “ama”, “madam” gibi.Verilen bir metin ve uzunlugunu kullanarak eger metin palindrom ise
            //1 degilse 0 döndüren özyinelemeli bir fonksiyon yazınız.Herhangi bir kütüphane fonksiyonu kullanamazsınız.
            //Not: bas ̧ ve son karakterleri esit olan ve ortası palindrom olan metin palindromdur. int palindrom(String str, int n)          

            Palindrom("ama");

            Console.ReadLine();   
            


        }

        private static void Palindrom(string text)
        {
            int n = text.Length;
            for(int i=text.Length-1,j=0; i>=0; i--,j++)
            {
                char[] x =new char[text[i]];
                
            }

            if (n==0)
            {
                Console.Write("1");
            }
            else
            {
                Console.Write("0");
            }
        }

    }
}
