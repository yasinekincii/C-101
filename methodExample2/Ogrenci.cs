using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodExample2
{
    internal class Ogrenci
    {     
        public void bilgiler()
        {
            Console.WriteLine("öğrencinin bilgilerini giriniz: ");

            Console.Write("Öğrencini ismi: ");
            string name = Console.ReadLine();

            Console.Write("1.sınav notunu giriniz: ");
            double not1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("2.Sınav notunu giriniz: ");
            double not2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("3.Sınav notunu giriniz: ");
            double not3 = Convert.ToDouble(Console.ReadLine());

            double ortalama = (not1 + not2 + not3) / 3;

            Console.WriteLine("{0} isimli öğrencinin notları: {1},{2},{3}",name,not1,not2,not3);

            Console.WriteLine("{0} isimli öğrencinin ortalaması: {1}",name,ortalama);

            if (ortalama>45)
            {
                Console.WriteLine("Dersi geçtiniz");
            }
            else
            {
                Console.WriteLine("Dersten kaldınız");
            }

        }

        

    }
}
