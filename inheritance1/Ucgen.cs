using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance1
{
    internal class Ucgen:IkiBoyut
    {
        //üçgen iki boyut içerisindeki genişlik ve yüksekliğe ihtiyaç duyar.

        public string Stil { get; set; }

        public void StilGoster()
        {
            Console.WriteLine("Stil: "+Stil);
        }

        public double AlanHesapla()
        {
            return Genislik * Yukseklik / 2;

            //üçgenin içerisinde genişlik veya yükseklik yok ama bunu ikiboyut içerisinden 
            //miras aldık
            
        }
    }
}
