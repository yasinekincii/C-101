using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMethod

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //random programlamada rastgele değerler üretmek için kullanacağımız sınıfımız

            Random number = new Random();

            int a, b,c;
            a = number.Next(0,10);//0 değeri dahil ve 10 a kadar random bir sayı atar
            b = number.Next(0,10);

            Console.WriteLine(a);
            Console.WriteLine(b);

            c = number.Next(50);//yine 0 50 arası random bir değer atıyacak
            Console.Write(c);



            Console.Read();
        }
    }
}
