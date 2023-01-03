using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paramsMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sum(1,2,3,4,5,6,7,8,9);

        }



        static void sum(params int[] numbers) //params değişkenimi en son parametre olarak almalıyım
        {
            int toplam = 0;
            for(int i=0; i<numbers.Length; i++)
            {
                toplam += numbers[i];
            }

            Console.WriteLine("Toplanan sayıların değeri: {0}",toplam);
        }
    }
}
