using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    internal class Program
    {
        //metotu global alana yazıyoruz.
        private static void data()
        {
            Console.WriteLine("Müdür: Doğukan Şenol");
            Console.WriteLine("Öğretmen: Barış Özer");
            Console.WriteLine("Okul: KHAL");
            Console.WriteLine("Eğitsel kol:Kütüphanecilik");
            Console.WriteLine("Şehir: İstanbul");
            Console.WriteLine(DateTime.Now.ToLongDateString());
        }


        static void Main(string[] args)
        {
            //Metot programın herhangi bir yerinde kullanılmak için tasarlanmış alt programlardır.Metotlar bizi kod fazlalığından kurtarır.

            data();

            Console.ReadLine();
        }
    }
}
