using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntExample3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad, soyad, numara;
            int sınav1, sınav2, sınav3, proje, ortalama;

            Console.WriteLine("****Öğrenci Bilgi****");
            Console.WriteLine();

            ad = "Mehmet";
            soyad = "yücedağ";
            numara = "12345678";

            Console.WriteLine("ad:"+ad);
            Console.WriteLine("Soyad:{0}",soyad);
            Console.WriteLine("numara:{0}",numara);

            Console.WriteLine();
            Console.WriteLine("****Ortalama****");
            Console.WriteLine();
            sınav1 = 60;
            sınav2 = 70;
            sınav3 = 100;
            proje = 90;

            Console.WriteLine("sınav1:"+sınav1);
            Console.WriteLine("sınav2:{0}",sınav2);
            Console.WriteLine("sınav3:{0}",sınav3);
            Console.WriteLine("proje:"+proje);

            Console.WriteLine();
            Console.WriteLine("****Ortalama Bilgi****");
            Console.WriteLine();

            ortalama = (sınav1 + sınav2 + sınav3 + proje) / 4;
            Console.WriteLine("Ortalama:"+ortalama);


            Console.Read();
        }
    }
}
