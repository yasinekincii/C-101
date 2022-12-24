using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exampleOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            do
            {
                Console.Write("Bir Sayı Giriniz= ");
                x = Convert.ToInt32(Console.ReadLine());

            } while (x%2==0);

            int y = 0;
            while (y % 2 == 0)
            {
                Console.Write("2. sayıyı giriniz= ");
                y = Convert.ToInt32(Console.ReadLine());
            }

            Console.ReadLine();
        }
    }
}
