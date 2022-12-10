using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tekar gerektiren ifadelerde kullanılan komutlardır.Döngüler bizi tekrarlı ifadelerde sürekli gereksiz kod yükünden kurtarıyor.

            //int i;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Hello World");
            }
            Console.WriteLine();


            for (int j = 2; j <= 20; j += 2)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine();


            int sum = 0;
            for(int k=1; k<=10 ; k++)
            {
                sum = sum + k;
            }
            Console.WriteLine("Toplam={0}",sum);


            Console.ReadLine();
        }
    }
}
