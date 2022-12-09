using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dikdört ve karenin alanı ve çevresi
            int kareninKenari,kareninCevresi,kareninAlani;

            Console.WriteLine("***KARENİN ALANI***");
            Console.WriteLine();

            Console.Write("Karenin bir kenarını giriniz= ");
            kareninKenari = Convert.ToInt32(Console.ReadLine());
            kareninCevresi = kareninKenari * 4;
            kareninAlani = kareninKenari * kareninKenari;

            Console.WriteLine("Kenarı verilen karenin alanı={0},çevresi={1}",kareninAlani,kareninCevresi);

            Console.WriteLine();
            Console.WriteLine("***DİKDÖRTGENİN ALANI VE ÇEVRESİ***");
            int kısaKenar, UzunKenar, dikdortgenAlan, dikdortgenCevre;

            Console.Write("Dikdörtgenin kısa kenarını giriniz= ");
            kısaKenar = Convert.ToInt32(Console.ReadLine());

            Console.Write("Dikdörtgenin uzun kenarını giriniz= ");
            UzunKenar = Convert.ToInt32(Console.ReadLine());

            dikdortgenAlan = kısaKenar * UzunKenar;
            dikdortgenCevre = (kısaKenar + UzunKenar) * 2;

            Console.WriteLine("Kenar uzunlukları girilen dikdörtgenin alanı= {0}, çevresi={1}",dikdortgenAlan,dikdortgenCevre);
            


            Console.Read();
        }
    }
}
