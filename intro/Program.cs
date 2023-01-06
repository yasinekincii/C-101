using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bizim classlarımız namespacelerimizin altında durur

            Musteri M1 = new Musteri();
            //string gibi müşteri nesnemi de tanıdı.Müşteri bir classtır diyor.
            //classın tanımını yaptıktan sonra oluşturmak istediğim nesneme sistem içerisinde çağırabileceğim bir isime ihtiyacım var.=M1 ismiyle bu nesneyi çağırmak istiyorum
            //new anahtar kelimesinin yardımıyla sistemde bu nesnenin bir örneğini oluşturucağım
            //new dedikten sonra nesnemi çağırıyorum .Parantezlerim var biz bunlara contructor diyoruz 
            //nesnemi örnekledim

            //m1 . operatörü ile nesnenin içerisindeki tanımlara ulaşabiliyoruz.

            //erişim belirleyicisi public olduğunda genele açık oluyor
            //private olduğunda kendi içinde kullanabiliyoruz.

            //class'ımız içerisindeki field'larımızı public dersek dış dünyaya açabiliyoruz private dersek classın içerisinde kullanabiliyoruz

            M1.tcKimlikNumara ="123";
            M1.isim = "Cengiz";
            M1.soyisim = "akın";
            M1.cinsiyet = 717770001;

            //müşteri classı içerisinde oluşturduğumuz bir fieldı yine müşteri classı içerisindeki metotların birisinde kullanıyor ve bunu dış dünyaya açma ihtiyacı duymuyorsak bunu private olarak bırakabiliriz ama dış dünyadan bir müşteri nesnesi oluşucağı zaman temel ihtiyaçlarımızı almak için fieldlarımızı public olarak işaretlemeliyiz


            Musteri M2 = new Musteri();//oraya baktın git oradaki alanlara aşağıdakileri yaz

            //değer atamaya başlıyorum
            M2.tcKimlikNumara = "1517";//m2'nin ram üzerinde işaret etmiş olduğu bölgenin içerisindeki tc kimlik numarasına bir değer ataması yaptım
            
            // aynısını isim,soyisim ve cinsiyet için de yapalım.
            M2.isim = "yasin";
            M2.soyisim = "ekinci";
            M2.cinsiyet = 717770001;

            Musteri M3 = M2;    //m3 null şu an M3'e diyorum ki git M2'nin yanına neye bakıyorsa sen de oraya bak

            //sistemde ben bir müşteri pointerı daha oluşturdum adı M3 ama bu M3'ün özel bir değeri olmayacak M2 ne gösteriyorsa M2'nin ramdeki değeri neyse    aynısını alsın ,aynısını göstersin bir referans veriyorum.Git M2 nereye bakıyorsa sen de oraya bak diyorum

            //M3 üzerinden bir değeri değiştirdiğimde ikisinin de etkilenmesi gerekir

            M3.isim = "Murat";
            M2.tcKimlikNumara = "1111";


            bool musteriKont = M2.MusteriKontrol();

            //M2.musterikontroldatabase     yapamıyoruz çünkü kontroldatabase metodunun erişim belirleyicisi private
            
            
            
            
            
            M3 = null;
            M2 = null;
            M1 = null;

            string isim = M3.isim;






        }
    }
}
