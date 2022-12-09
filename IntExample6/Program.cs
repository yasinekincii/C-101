using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntExample6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kenar, kareninCevresi, kareninAlani;
            int kisaKenar, uzunKenar, dikdortgenCevre, dikdortgenAlan;

            Console.WriteLine("***Karenin alanı ve çevresi***");
            Console.WriteLine();

            Console.WriteLine("Karenin kenarını giriniz");
            kenar = Convert.ToInt32(Console.ReadLine());
            kareninCevresi = kenar * 4;
            kareninAlani = kenar * kenar;
            Console.WriteLine("Karenin çevresi={0},Karenin alanı={1}",kareninCevresi,kareninAlani);


            Console.WriteLine();
            Console.WriteLine("***Dikdörtgenin alanı ve çevresi***");
            Console.WriteLine();

            Console.WriteLine("Dikdörtgenin kısa kenarını giriniz");
            kisaKenar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dikdörtgenin Uzun Kenarını Giriniz");
            uzunKenar = Convert.ToInt32(Console.ReadLine());

            dikdortgenCevre = (kisaKenar + uzunKenar) * 2;
            dikdortgenAlan = kisaKenar * uzunKenar;

            Console.WriteLine("Dikdörtgenin Çevresi={0}, Dikdörtgenin Alanı={1}",dikdortgenCevre,dikdortgenAlan);


            Console.ReadLine();
        }
    }
}
