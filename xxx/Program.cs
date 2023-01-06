using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcı tarafından girilen üç sayıdan en büyük ile en küçük sayıyı toplayıp toplam sonucu ekrana yazdıran programı yazınız.

            decimal[] numbers = new decimal[5];

            decimal minValue = decimal.MinValue;
            decimal HighestValue = decimal.MaxValue;

            for (int i=0;i<numbers.Length;i++)
            {
                Console.Write((i+1)+". Değeri giriniz: ");
                numbers[i] = Convert.ToDecimal(Console.ReadLine());

                if (numbers[i]< HighestValue)
                {
                    HighestValue = numbers[i];
                }
                if (numbers[i]> minValue)
                {
                    minValue = numbers[i];
                }                
            }

            Console.Clear();
            System.Threading.Thread.Sleep(5000);

            Console.WriteLine($"\nen büyük sayı: {minValue}, en küçük sayı: {HighestValue} ");
            Console.WriteLine();




            Console.ReadLine();
        }
    }
}
