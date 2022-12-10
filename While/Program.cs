using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while -iken anlamı taşıyor.Müddet anlamı var biraz da 

            int i = 0;

            while (i < 10) //i küçük 10 olana kadar aşağıdaki işlemi yap
            {
                Console.WriteLine("merhaba çanakkale");
                i++;
            }


            //1 ile 10 arasındaki sayıları listeleyen program

            int j = 1;
            while (j<=10)
            {
                Console.WriteLine(" " + j);
                j++;                
            }

            //klavyeden tek sayı girilene kadar kullanıcıdan sayı isteyen programı gerçekleştirelim.

            int number;
            Console.Write("Bir sayı giriniz= ");
            number = Convert.ToInt32(Console.ReadLine());

            while(number % 2 == 0)//while içerisindeki şartı sağlamadığı zaman dışarı çıkıcak
            {
                Console.WriteLine("Çift bir sayı girdiniz="+number);
                Console.WriteLine("Bir sayı giriniz");
                number = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Tek sayı girdiniz");



            Console.Read();
        }
    }
}
