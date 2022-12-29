using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variablesExamples2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba");

            Console.Write("isminiz Nedir ? ");
            string name = Console.ReadLine();

            Console.Write("Soyisminiz Nedir?");
            string lastName = Console.ReadLine();

            Console.Write("Yaşadığınız şehri girin");
            string city = Console.ReadLine();

            Console.Clear();//console altındaki clear komutunu kullanıyoruz.Ekranı temizlememize yarıyor

            Console.WriteLine("İsim: "+name);
            Console.WriteLine("Soyisim: "+lastName);
            Console.WriteLine("Şehir: "+city);

            Console.ReadLine();
        }
    }
}
