using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodExample10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bu yazıda bir metin içindeki sadece harfleri, harf ve rakamları saymayı ayırıca hazır metot(Length) kullanarak metindeki tüm karakterleri saymayı göstereceğiz.

            Console.WriteLine("Bir metin giriniz:");
            string text = Console.ReadLine();
            text=text.ToLower();

            Character(text);
            NumbersAndCharacters(text);

        }

        public static void Character(string str)
        {
            Console.Clear();
            char[] alphabet = { 'a', 'b', 'c', 'ç', 'd', 'e', 'f', 'g', 'ğ', 'h', 'ı', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z' };
            Console.WriteLine("Girilen metin içerisindeki harfler:  ");

            for (int i=0; i<str.Length;i++)
            {
                
                if (alphabet.Contains(str[i]))
                {
                    Console.Write(str[i]+", ");
                }
            }
        }


        public static void NumbersAndCharacters(string str)
        {
            Console.Clear();
            char[] alphabet = { 'a', 'b', 'c', 'ç', 'd', 'e', 'f', 'g', 'ğ', 'h', 'ı', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z' };
            char[] numbers = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] chr = new char[alphabet.Length + numbers.Length];

            alphabet.CopyTo(chr, 0);
            numbers.CopyTo(chr, alphabet.Length);

            int alp = 0;
            int num = 0;


            for(int i=0; i < str.Length; i++)
            {
                if (chr.Contains(str[i]))
                {
                    if (numbers.Contains(str[i]))
                    {
                        num++;

                    }
                    if (alphabet.Contains(str[i]))
                    {
                        alp++;
                    }

                }
            }
            Console.WriteLine("Girilen metinde {0} adet harf, {1} adet sayı bulunmaktadır.",alp,num);
        }













    }
}
