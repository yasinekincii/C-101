using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_2
{
    public class Ogrenci //classımızı bütün uygulama içerisinde kullanabilmek için public olarak işaretliyeceğiz(bunlara erişim belirleyici deniliyor)
    {
        //bu erişim belirleyicileri ile classlarımızı ya da metotlrımızın erişim noktalarını ayarlayabiliyoruz
        //biz burada classımızın başına public yazarak açmış olduğun classı herhangi bir başka classtan çağırabilirsin,kullanabilirsin ya da başka bir kütüphane olarak bu proje eklendiğinde insanların da bu classa ulaşmasını sağlayabilirsin
        //biz burada main metodumdan Ogrenci nesneme erişebilmek ve erişmiş olduğum Ogrenci nesnemi de kullanabilmek istiyorum

        public void selamlaOgrenci()////eğer metotlarımız bir değer ataması yapmıyorsa void olarak işaretleyebiliyoruz
        {
            Console.WriteLine("Merhaba Ogrenci");
        }


        /*
         * [Erişim Belirleyici] <Geri Dönüş Değeri> Metot adı(parametreler)
         * {
         *      //Metot için gereken kodlar
         * }
         * 
         * 
         * Erişim Belirleyicisi
         * 
         * Public       //public dediğimiz zaman metodumuza şunu söylemiş oluyoruz.Ben bu metodu class'ın içerisinden değil benim classıma ulaşan herkesin bu metoda da ulaşmasını istiyorum diyoruz
         * Private      //private dediğimiz zaman benim oluşturmuş olduğum bu metod içerisinde bulunmuş olduğu class düzeyinde çağırılabilir.Benim Ogrenci nesneme ulaşan bir insan bu metoduma ulaşamasın özel olarak classın içerisinde ulaşılsın demiş oluyoruz
         * 
         * 
         * Buradan sonrasını polimorfizm başlığı altında 
         * Protected    //kalıtım konusunda yoğun olarak kullanacağımız bir erişim belirleyicisidir.Birbirinden nesneler kalıtıldığında protected olarak kullanılabiliyor.
         * 
         * Internal     //İlgili uygulama içerisinde(kütüphane de deniliyor buna) ilgili kütüphane içerisinde metoda ulaşabilirsin diyebiliyoruz
         * 
         * Internal Protected   //uygulama içerisinde ulaşabilirsin veya bir yerden kalıtıldıysa ulaşabilirsin diyoruz
         * 
         * 
         */

        //metot örnekleri
        //class ın dışarısından erişilmesini istiyorum benim classıma ulaşan herkesin metodumu görmesini istiyorum.Bu yüzden erişim belirleyicisi kısmına public yazıyorum
        //geri dönüş değerimin herhangi bir şey olmasını istemiyorum.Herhangi bir geri dönüş değerine sahip olmayacaksa metotlarımız bir işlemi yapıp sonlanıcaksa o zaman geri dönüş değerine void olarak yazıyoruz.

        private void OgrenciMetot1(string ogrenciAdi, string ogrenciSoyadi)
        {
            Console.WriteLine("Öğrenci bilgileri: {0} {1}", ogrenciAdi, ogrenciSoyadi);
        }

        public void OgrenciMetot2()
        {
            OgrenciMetot1("yasin", "ekinci"); //private olarak işaretlemiş olduğumuz için Ogrenci classı içerisinde herhangi bir metodda ben private metoduma ulaşabiliyorum
        }

        //public: class'ın dışarısında bir classı örnekledikten sonra o classın dış dünyaya açılmasını istediğimiz metotları işaretlediğimiz erişim belirleyicisi olarak düşünün
        //private: o classın içerisinde kullanılıcak o class'a ait özel olan erişim belirleyicisi olarak düşünebilirsiniz

    }
}
