using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntExample5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, toplam, fark, carpim, bolum;

            Console.WriteLine("****ARİTMETİK İŞLEMLER****");
            Console.WriteLine();

            Console.WriteLine("1.Sayıyı Giriniz");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. Sayıyı Giriniz");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            toplam = sayi1 + sayi2;
            fark = sayi1 - sayi2;
            carpim = sayi1 * sayi2;
            bolum = sayi1 / sayi2;

            Console.WriteLine("Toplam={0},Fark={1},Çarpım={2},Bölüm={3}",toplam,fark,carpim,bolum);
           
            Console.Read();
        }
    }
}
