using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variablesExamples3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba");

            Console.Write("İsminizi girin: ");
            string name = Console.ReadLine();

            Console.Write("Şehir giriniz: ");
            string city = Console.ReadLine();

            Console.Write("Yaşınızı girin: ");
            string age = Console.ReadLine();
            int intParse = int.Parse(age);
            int intConvert = Convert.ToInt32(age);
            int yasConvert2 = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("İsminiz= {0}\nŞehir= {1}\nYaş= {2}",name,city,age);


            Console.ReadLine();
        }
    }
}
