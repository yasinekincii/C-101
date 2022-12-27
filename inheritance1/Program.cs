using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IkiBoyut iki = new IkiBoyut();
            iki.Genislik = 10;
            iki.Yukseklik = 20;
            iki.Goster();

            Console.WriteLine("***************");

            Ucgen uc = new Ucgen();
            uc.Genislik = 30;
            uc.Yukseklik = 20;
            uc.Stil = "üçgen";
            uc.StilGoster();
            Console.WriteLine("Alan: "+uc.AlanHesapla());
            uc.Goster();
            

            Console.ReadLine();
        }
    }
}
