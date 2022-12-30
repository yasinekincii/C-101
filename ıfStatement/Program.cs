using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ıfStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if
            Console.Write("1.Sayıyı giriniz: ");
            string str1 = Console.ReadLine();

            Console.Write("2. sayıyı giriniz: ");
            decimal d2 = Convert.ToDecimal(Console.ReadLine());

            decimal d1 = Convert.ToDecimal(str1);

            decimal toplam = d1 + d2;

            bool toplamKontrol = toplam > 50;

            if (toplamKontrol)
            {
                Console.WriteLine("Girilen sayilarin toplami 50'den büyüktür.");
            }
            ///////////////////////////////////////////

            if (toplam>=100)
            {
                Console.WriteLine("Girdiğiniz sayıların toplamı 100'den büyüktür.");
            }
            else if (toplam>=50)
            {
                Console.WriteLine("Girdiğiniz sayıların toplamı 50'den büyüktür.");
            }
            else
            {
                Console.WriteLine("Sayıların toplamı 50'den küçüktür.");
            }
        }
    }
}
