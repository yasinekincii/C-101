using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionsNote
{
    internal class Program
    {
        private static void worldCup()
        {
            Console.WriteLine("Dünya kupası Katar'da düzenlendi.");
            Console.WriteLine("İlk defa bir Dünya kupası kışın yapıldı.");
            Console.WriteLine("Fas tarih yazdı.");
            Console.WriteLine("Almanya gruplardan çıkamadı.");
            Console.WriteLine("Final maçı 18 aralık günü oynanıcak.");
            //Console.WriteLine(""DateTime.Now.ToLongDateString());

        }


        static void Main(string[] args)
        {
            worldCup();


            Console.Read();
        }
    }
}
