using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class4
{
    internal class Program
    {
        //kalıtım nedir?
        //birden fazla sınıfımız olsun bazı alanları tek bir nesnede toplamak istiyoruz
        static void Main(string[] args)
        {
            Ucak uck = new Ucak();//böyle yaptığımda uck nın yolcu kısmını kullanamıyorum
            //yolcunun adını,soyadını,yaşını ve cinsiyetini kullanmak istiyorum BUNU NASIL YAPACAĞIM?
            //KALITIM kullanarak
            //nereden kalıtım almak(türetmek) istiyorum =yolcu sınıfından  peki nereye uçak sınıfına

            //class Ucak:Yolcu dediğimde kalıtımı sağlamış oldum.
            //yolcu sınıfındaki erişim belirleyicileri değişkenleri uçak sınıfına aktarmış olduk.

            //bunu yaptıktan sonra uck. dediğimizde yolcunun değişkenlerine erişim belirleyicilerine ulaşmış oluyoruz

            uck.MARKA = "THY";
            uck.KALKIS = "Adana-şakirpaşa";
            uck.VARIS = "İstanbul-Sabiha gökçen";
            uck.ADI = "yasin";
            uck.SOYADI = "ekinci";
            uck.YASI = -23;
            uck.CINSIYET = "Erkek";

            Console.WriteLine("Hava yolu= {0}\nVarış yeri= {1}\nYolcunun adı= {2}\nYolcunun Soyadı= {3}\nYolcunun Yaşı= {4}\nYolcunun cinsiyeti= {5}",uck.MARKA,uck.KALKIS,uck.VARIS,uck.ADI,uck.SOYADI,uck.YASI,uck.CINSIYET);


            Console.ReadLine();
        }
    }
}
