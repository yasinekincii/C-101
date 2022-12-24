using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exampleFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 1;

            Console.Write("Bir sayi giriniz= ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i =number; i>=1; i--)
            {
                total=total* i;
            }

            Console.WriteLine("Girilen {0} Sayısının Fonksiyonu= {1}",number,total);


            Console.ReadLine();
        }
    }
}
