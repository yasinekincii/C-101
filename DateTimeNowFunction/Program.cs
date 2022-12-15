using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeNowFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //date tarih,time saat demek
            //zaman için datetime adında bir zaman kullanıyoruz.

            DateTime zaman;
            zaman = DateTime.Now;
            Console.WriteLine("Tarih ve Zaman: {0}",zaman);

            int ay = zaman.Month;
            int gun = zaman.Day;
            int yıl = zaman.Year;

            DayOfWeek haftanıngunu = zaman.DayOfWeek;

            Console.WriteLine("Gün: {0}",gun);
            Console.WriteLine("Ay:{0}",ay);
            Console.WriteLine("Yıl:{0}",yıl);
            Console.WriteLine("Haftanın Günü: {0}",haftanıngunu);

            
            Console.ReadLine();
        }
    }
}
