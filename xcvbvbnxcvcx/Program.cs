using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xcvbvbnxcvcx
{
    internal class Program
    {
         static void Main(string[] args)
        {
            Kutu k = new Kutu();

            Kutu ka = new Kutu(5,8,10);
            

            ka.SetUzunluk(7);
            Console.WriteLine(ka.GetUzunluk());


            k.Genislik = -30;
            Console.WriteLine(k.Genislik);


            k.Yukseklik = -10;
            Console.WriteLine(k.Yukseklik);



            Console.WriteLine(k.GetAccount(-10));

            Console.ReadLine();
        }     
     

    }
}
