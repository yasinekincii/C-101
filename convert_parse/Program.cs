using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convert_parse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string metin1 = "100"; //bu 100 değerini bir int değerine atamak istediğimizde

            //int s1 = (int)metin1;  bunun içerisinde 100 değeri var ve ben bunu inte aktarmak istiyorum.
            
            //2 yöntem var
            int s1 = int.Parse(metin1); //int içerisinde bulunan parsed metodumuz.Burada uygulamaya ben sana bir string vericeğim.Stringin içerisindeki değer senin min ve max değerlerin arasında bulunan bir değerdir diyorum.
            //int.parse komutu stringi alıyor ve bunu inte çevirip s1'in üzerine atıyor.Bundan sonra da değeri bir int gibi kullanabiliyoruz


            int s2 = Convert.ToInt32(metin1); // convert.toınt32 komutunu çağırıyorum ve diyorum ki metin1 i sen inte çevir diyorum

            //////////////////
            string metin2 = "True"; //bunu boolean'a çevirmek istersek
            bool b1 = bool.Parse(metin2); //bool içerisine gidip . operatörü ile onun komutlarını görüyoruz ve burada bir parse komutu görüyoruz
            //parse komutu ben bir string değer alırım geriye de bool bir değer döndürürüm diyor

            bool b2 = Convert.ToBoolean(metin2);

            ///////////////////////////////
            string metin3 = null;
            decimal d1 = decimal.Parse(metin3);//Parse metodunda null hatası alırız
            decimal d2 = Convert.ToDecimal(metin3);//convertte değer null ise program hata vermicek ilgili çevirimi gerçekleştirmicek hata verip uygulamayı pataltmyaym diyor.Çalışmasına devam etsin developer içeride karar 0 değilse diye karar yapısı koymuştur diyor
            //ilgili değişkenin aldığı standart(default) değeri bırakıyor.

            bool b3 = Convert.ToBoolean(metin3);


        }
    }
}
