using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examplePrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            Console.WriteLine("Bir sayı giriniz= ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number>1)
            {
                for (int i = 2; i < number; i++)
                {
                    if(number % i==0)
                    {
                        count++;
                    }
                }
                if (count > 0)
                {
                    Console.WriteLine("Girilen sayı asal sayı değildir.");
                }
                if (count==0)
                {
                    Console.WriteLine("Girilen sayı asaldır.");
                }

            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız");
            }

            
            


            Console.Read();
        }
    }
}
