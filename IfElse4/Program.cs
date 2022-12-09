using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //klavyeden girilen öğr notunun orta göre geçip ya da kaldığını bulan
            int sinav1, sinav2, ortalama;

            Console.Write("1. SınavNotunuzu Girin");
            sinav1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.Sınav Notunuzu Girin");
            sinav2 = Convert.ToInt32(Console.ReadLine());

            ortalama = (sinav1+sinav2) / 2;
            Console.WriteLine("Ortalama değeriniz= "+ortalama);

            if (ortalama >= 50)
            {
                Console.WriteLine("Geçtiniz!!!");
            }
            else
            {
                Console.WriteLine("Kaldınız:((");
            }

            Console.ReadLine();
        }
    }
}
