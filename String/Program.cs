using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string isimSoyisim = "Yasin EKİNCİ";
            Console.WriteLine(isimSoyisim);

            isimSoyisim = "Mustafa Taş";
            Console.WriteLine(isimSoyisim);

            string buyukKarakter = isimSoyisim.ToUpper();//değişkenin içersindeki değerlerin hepsini büyük harfe çeviricek
            string kucukKarakter = isimSoyisim.ToLower();//değişkenin içerisindeki değerlerin hepsini küçük harfe çeviricek
            string belirliBirBolum = isimSoyisim.Substring(2,4);//start index=2 biz programa 2. indeksten başla(dahil) 4 karakter al dedik


            Console.ReadLine();
        }
    }
}
