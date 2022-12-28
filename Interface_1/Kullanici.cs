using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_1
{
    internal class Kullanici : Ikullanici
    {
        //bunu oluşturmam için kalıtım uygulamam gerekiyor.
        //kızardı bende sınıfına dahil etmen gereken şunlar var diye hata verdi
        //üstüne geldim implement interface dedim.Hepsini projeme dahil etti

        public void Aktif(int kullaniciId)
        {
            //burası geliştiricinin kullanacağı alandır.
        }

        public void Ekle(string kullaniciAd, string email, string sifre)
        {
            throw new NotImplementedException();
            //kullaniciad,email ve şifre bilgisiyle yeni bir kullanıcı oluştur
        }

        public KullaniciInfo Getir(int kullaniciId)
        {
            KullaniciInfo inf = new KullaniciInfo();
            inf.ID = 11;
            inf.Ad = "yasin";
            inf.Soyad = "ekinci";
            return inf;
        }

        public bool Giris(string email, string sifre)
        {
            throw new NotImplementedException();
        }

        public void Guncelle(int kullaniciId, string kullaniciAd, string email, string sifre)
        {
            throw new NotImplementedException();
        }

        public List<KullaniciInfo> KullanicialariGetir()
        {
            throw new NotImplementedException();
        }

        public void Pasif(int kullaniciId)
        {
            throw new NotImplementedException();
        }

        public void Sil(int kullaniciId)
        {
            throw new NotImplementedException();
        }

        //interface_1 in üstüne gelip rebuild yaparak derleyebiliyorum.Ama herhangi bir şeyin adını değiştirirsem hata vericektir
        //interface i projene dahil ettiysen %100 uygulayacaksın hiçbir şey değiştiremezsin
        //sadece istersen sonuna ekleme yapabiliyorsun ekstra sil metoduna overload yapabilirsin
        public void Sil(string email)
        {
            throw new NotImplementedException();//ekstra yetenek ekledik burada sorun olmaz
        }
    }
}
