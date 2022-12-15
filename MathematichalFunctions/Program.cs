using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematichalFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Sayıyı Girin:\t");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mutlak Değerli Hali: "+Math.Abs(number));//absolute: mutlak değerini aldık.


            double number2;
            Console.WriteLine("Sayıyı girin: ");
            number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sayının üste yuvarlanmış hali: "+Math.Ceiling(number2)); //10,25 - 11'e yuvarlanıcak.


            double number3;
            Console.WriteLine("Sayıyı giriniz: ");
            number3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sayının alta yuvarlanmış hali: "+Math.Floor(number3));//nolursa olsun 10,99 - 10'a yuvarlanır


            //klavyeden girilen bir sayının 5. kuvvetini alalım.
            double number4;
            Console.WriteLine("Sayıyı Giriniz: ");
            number4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sonuç: "+ Math.Pow(number4,5)); //1. değer taban 2. değer üst olucak.


            //Klavyeden girilen sayının karekökünü bulalım.
            double number5;
            Console.WriteLine("Sayıyı Giriniz: ");
            number5 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Sonuç: " +Math.Sqrt(number5));//karekök komutumuz: Sqrt


            //cos bulalım
            double number6;
            Console.WriteLine("Dereceyi Giriniz: ");
            number6 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sonuç: " +Math.Cos(number6));


            //klavyeden girilen 2 sayıdan büyük ve küçük olanı bulalım.
            double number7, number8;
            Console.WriteLine("1. ve 2. Sayıyı Girin:");
            number7 = Convert.ToDouble(Console.ReadLine());
            number8 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Küçük Sayı:"+Math.Min(number7,number8));
            Console.WriteLine("Büyük Olan Sayı: " +Math.Max(number7,number8));














            Console.Read();
        }
    }
}
