using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntExample4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //convert işlemi:ilgili değer üstünde aritmetik işlem yapılacağını programa bildirmek için kullanılan yapıdır
            //convert dönüştürmek anlamına gelir. convert.to bir şeye dönüştürür

            int sayi1, sayi2, toplam;

            Console.WriteLine("***TOPLAMA İŞLEMİ***");
            Console.WriteLine();

            Console.WriteLine("1.Sayıyı Giriniz");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.sayıyı giriniz");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam:"+toplam);

            Console.Read();



        }
    }
}
