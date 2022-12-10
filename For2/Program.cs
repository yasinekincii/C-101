using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 ile 100 arasında 9'a tam bölünen sayıları listeleyen program
            //120 sayısının tam bölenleri bulan program
            //fibonacci serisinde ilk 10 elemanı listeleyen program

            Console.Write("9'a tam bölünen sayılar=");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 9 == 0)
                {
                    Console.Write(" " + i);
                }
            }
            Console.WriteLine();


            Console.Write("120 sayısının tam bölenleri=");
            for (int i = 1; i <= 120; i++)
            {
                if (120 % i == 0)
                {
                    Console.Write(" " + i);
                }
            }

            Console.WriteLine();
            int number1 = 1;
            int number2 = 1;
            int sum = 0;
            Console.Write(" {0} {1}", number1, number2);

            for (int i = 1; i <= 8; i++)
            {

                sum = number1 + number2;

                Console.Write(" " + sum);
                number1 = number2;
                number2 = sum;
            }
            //Console.WriteLine(sum);



            Console.Read();
        }
    }
}
