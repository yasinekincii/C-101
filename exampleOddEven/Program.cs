using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exampleOddEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz= ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number%2==0)
            {
                Console.WriteLine("Sayı Çifttir.");
            }
            else
            {
                Console.WriteLine("Sayı tektir.");
            }



            Console.ReadLine();
        }
    }
}
