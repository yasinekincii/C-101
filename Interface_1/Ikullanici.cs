using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_1
{
    internal interface Ikullanici
    {
        //class yerine interface yazıyor.


        //İnterface de sadece özetler yazılır.Bir metot yazıyorsak gövdesi yazılmaz.Sadece başlık ve
        //özet kısmı yazılır

        void Ekle(string kullaniciAd, string email, string sifre);
        // interface içerisinde gövdesini yazamayız hata verir.{}

        //içerisini interface i implemente eden kendi sınıfına uygulayan kişi yazıcak biz sadece gelen
        //kuralları yazdık.

        void Guncelle(int kullaniciId, string kullaniciAd, string email, string sifre);

        void Sil(int kullaniciId);//kullanıcılar kullanıcııd ile silinir diye bir kural belirtiliyor burada

        //kullaniciinfo adında bir sınıf oluşturduk.


        KullaniciInfo Getir(int kullaniciId);
        //getir metodu bana kullanıcı info dönücek burada
        //ben kullanıcıId'sini kullanarakgeliştiriceğim sorguda bunun içerisini doldururken buradaki
        // sağ tık peek info yapıcaksın bilgileri getirmem gerekiyor

        List<KullaniciInfo> KullanicialariGetir();

        void Aktif(int kullaniciId);

        void Pasif(int kullaniciId);

        bool Giris(string email, string sifre); 

        //buradan sonra bunu uygylayabileceğim geliştirici kısmına geçiyorum.
        //yeni bir sınıf oluşturuyorum adı kullanici




    }
}
