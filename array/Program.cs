using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ogrenciIsimListesi = new string[5];

            ogrenciIsimListesi[0] = "yasin ekinci";
            ogrenciIsimListesi[1] = "Mustafa";
            ogrenciIsimListesi[2] = "elif";
            ogrenciIsimListesi[3] = "ruhi";
            ogrenciIsimListesi[4] = "hayriye";

            foreach(string item in ogrenciIsimListesi)
            {
                Console.WriteLine(item);
            }

            Console.Clear();

            for(int i=0; i < ogrenciIsimListesi.Length; i++)
            {
                Console.WriteLine(ogrenciIsimListesi[i]);
            }
        }
    }
}
