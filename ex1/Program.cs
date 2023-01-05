using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Örnek 1: Girilen 3 basamaklı sayının basamaklarına ayıran örnek(Birler, Onlar, Yüzler Basamağındaki sayılar):

            YenidenBasla:
            Console.Write("3 Basamaklı Bir Sayı giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("====================");

            if (number>=0 && number<1000)
            {
                while (number > 0)
                {
                    Console.Write(number % 10+",  ");
                    number = number / 10;
                }
            }
            else
            {
                Console.WriteLine("Hatalı bir giriş yaptınız.Lütfen 3 basamaklı bir sayı giriniz: ");
                System.Threading.Thread.Sleep(5000);
                Console.Clear();

                goto YenidenBasla;
            }

            Console.ReadLine();
            
        }
    }
}
