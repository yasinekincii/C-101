using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //karşılaştırma operatörleri

            //karşılaştırma dediğimizde elimizde en az 2 tane nesnenin,değişkenin olması gerekiyor ki karşılaştırabilelim

            int s1 = 100, s2 = 150;
            //bool donusdegeri = degisken1>degisken2 


            //büyük mü karşılaştırması >            
            bool sonuc = s1 > s2;
            //bool geri dönüşe ihtiyacımız var s1 büyük mü s2 den            


            //küçük mü karşılaştırması<
            //bool donusDegeri= degisken1<degisken2  TRUE-FALSE
            bool sonucKucuk = s1 < s2;


            //Atama operatörü   =
            //degisken = AtanacakDeger;
            decimal decimalSayi1 = 10.90M;

            //eşit mi karşılaştırması  == , !=(eşit değil mi)

            bool esitKontrol1 = s1 == s2;//s1 s2'ye eşit mi
            bool esitKontrol2 = s1 != s2;


            //Büyük eşit mi karşılaştırması
            //bool donendeger=degisken1>=degisken2;

            bool buyukEsitSonuc = s1 >= s2;//program önce büyük mü diye bakıyor büyükse true değerini döndürüyor.Eğer büyük değilse program bu sefer de eşit mi diye bakıyo eşit ise true değerini dönderiyor.Eşit de değillerse false değerini dönderiyor.
                                           //iki şarttan bir tanesi doğruysa uygulama true kabul eder


            //küçük eşit mi karşılaştırması<=
            //bool donenDeger=degisken1<=degisken2;

            bool kucukEsitSonuc = s1 <= s2;

            //////////////////////////////////////////////////////////////////
            //object içerisine değeri aldığında o değerin hangi değişken tipinde olduğunu da alır
            //eğer int ise içindeki değer 10 ise 10 değerini objectin içinde görürsünüz ama görmediğiniz bir kısım daha vardır o 10 değerinin gelmiş old değişkenin tipi

            //is operatörü

            object o1 = s1;
            //objectin içindeki değeri ekrana yazdırdığımda içindeki değeri görebilicem string olarak çünkü object kendi içerisindeki bir komuttan dolayı(classlarda görücez) bize string olarak gösterilicek
            Console.WriteLine(o1);

            s1 = (int)o1;//bilinçsiz tür değişimi
            s1 = (byte)o1;









        }
    }
}
