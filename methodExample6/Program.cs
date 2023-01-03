using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodExample6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bu yazımızda C# Console uygulamasında metot kullanarak 4 işlemi gerçekleştiren basit bir uygulama yapacağız. Örneğimizde Topla, Çıkar,Çarp ve Böl isimli, 2 adet int türünde parametre alan metotlarımızı kullanarak sonucu ekranda göstereceğiz.

            Console.WriteLine("Girilen iki sayının toplamı: "+Topla(10,10));
            Console.WriteLine("Girilen iki sayının farkı: "+Fark(10,5));          
            Console.WriteLine("Girilen iki sayının Çarpımı: "+Carp(10,10));
            Console.WriteLine("Girilen iki sayının bölümü: "+Bolme(10,2));


            Console.ReadLine();
        }

        static int Topla(int n1,int n2)
        {
            return n1 + n2;
        }

        static int Fark(int n1,int n2)
        {            
            return Math.Abs(n1 - n2);
        }

        static int Carp(int n1,int n2)
        {
            return n1 * n2;
        }

        static int Bolme(int n1,int n2)
        {
            return n1 / n2;
        }
    }
}
