using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodExample7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayıyı giriniz: ");
            oddOrEven(Convert.ToInt32(Console.ReadLine()));

            Console.ReadLine();
        }

        static void oddOrEven(int n)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine(n+" Sayısı çifttir.");
            }
            else
            {
                Console.WriteLine(n+ " Sayısı tektir.");
            }
        }
    }
}
