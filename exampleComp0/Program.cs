using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exampleComp0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("0 dan büyüktür.");
            }
            else if (number==0)
            {
                Console.WriteLine("Sayı 0'a eşittir.");
            }
            else
            {
                Console.WriteLine("Sayı 0'dan küçüktür.");
            }



            Console.ReadLine();
        }
    }
}
