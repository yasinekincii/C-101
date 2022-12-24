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

        private static int palindrom(string text,int length)
        {
            for (int i=length-1,j=0 ; i>=0; i--,j++ )
            {
                if (text[i] == text[j])
                {
                    length--;
                }
            }

            length += 1;

            if (length == 1)
            {                
                return length;
            }
            else
            {
                length = 0;
                return length;

            }          
          
        }

        static void Main(string[] args)
        {
            //Tersi kendisiyle aynı olan metinlere palindrom denilir.Mesela “ama”, “madam” gibi.Verilen bir metin ve uzunlugunu kullanarak eger metin palindrom ise
            //1 degilse 0 döndüren özyinelemeli bir fonksiyon yazınız.Herhangi bir kütüphane fonksiyonu kullanamazsınız.
            //Not: bas ̧ ve son karakterleri esit olan ve ortası palindrom olan metin palindromdur. int palindrom(String str, int n)

            Console.WriteLine(palindrom("madam",5));

            Console.Read();

        }
    }
}
