using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodExample9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bu yazımızda double türünde girilen 2 yazılı notunu parametre olarak alan ve geriye string olarak “Geçti” yada “Kaldı” döndüren bir metot oluşturarak kullanımını gösteren bir örnek oluşturacağız. Örneğimizde kullanıcıdan 1. ve 2. yazılı notu istenecek ve bu değerler “durum” isimli metoda gönderilerek geriye dönen string değerin ekranda gösterilmesini sağlayacağız.

            Console.Write("Kullanıcının 1. Sınav notunu giriniz: ");
            double midterm = Convert.ToDouble(Console.ReadLine());

            Console.Write("Kullanıcının 2.Sınav Notunu giriniz: ");
            double final = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(result(midterm, final));

            Console.ReadLine();
        }

        static string result(double g1,double g2)
        {
            if(((g1 * 0.4) + (g2 * 0.6)) > 50)
            {
                return "Geçtiniz";
            }
            else
            {
                return "Kaldınız";
            }

        }


    }
}
