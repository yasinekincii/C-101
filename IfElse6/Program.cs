using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse6
{
    internal class Program
    {
        static void Main(string[] args)
        {//klavyeden girilen sayının tek mi çift mi olduğunu bulan uygulama

            int sayi;
            Console.Write("Sayıyı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi % 2 == 0)
            {
                Console.WriteLine("Sayı çifttir");
            }
            else
            {
                Console.WriteLine("Sayı Tektir");
            }


            //klavyeden girilen sayının 5'e tam bölünüp bölünmediğini bulan prog

            double number;
            Console.WriteLine("Bir sayı giriniz");
            number = Convert.ToDouble(Console.ReadLine());

            if (number % 5 == 0)
            {
                Console.WriteLine("Girilen sayı 5'e tam bölünür");
            }
            else
            {
                Console.WriteLine("Girilen sayı 5'e tam bölünmez");
            }





            Console.ReadLine();
        }
    }
}
