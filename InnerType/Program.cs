using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Inner type modelleme

            Musteri M1 = new Musteri();

            //M1 stack tarafta içerisi ise heap bölgede açılırken içeride tanımlamış olduğum field'larım default değerlerini alıcaklar.(int=0,string=null)
            //koleksiyonlarım da null olarak default değeri aldı(madres,miletisimbilgisi,msiparisbilgisi)

            #region Standart Tekil Olan Field'larım
            M1.musteriID = 1;
            M1.tcKimlikNumarasi = "123";
            M1.isim = "cengiz";
            M1.soyisim = "Atilla";
            M1.olusturmaTarih = DateTime.Now;
            #endregion

            //====================================================================================================
            //====================================================================================================

            #region inner type
            //Bir müşteri nesnesi oluşturduk, oluşturmuş olduğumuz müşteri nesnesi içerisindeki müşteri adresleri koleksiyonumun 0. indeksine bir müşteri adresi tanımı yaptım.Müşteri adres de müşteri de bizim özel tiplerimiz burada inner type ı yakalamış olduk

            //M1.musteriAdresleri = new MusteriAdres[5];    BU KULLANIM ÖNERİLMEZ
            //dizi tanımını yaptım.
            //new ile örneklediğimde M1 nesne örneğinde müşteriadreslerinin 5 elemanlı bir dizi olarak sisteme kendini tanıtıcak
            //Bundan sonra 0. indeksine yeni bir müşteri adresi ekleyebilirim.

            M1.musteriAdresleri[0] = new MusteriAdres()
            {
                il = "İstanbul",
                ilce = "K.Çekmece",
                adres = "Adres...",
                adresTip = "İş yeri"
            };

            //object referans not set hatası aldım.Bunun sebebi içeride koleksiyon olarak tanımlamış olduğum innertypeların default değerleri null şeklinde, henüz dizimizi örneklemediğimiz için bu hatayı aldık.Bunun 2 çözümü var=>
            //Müşteri nesnesini oluşturduğunuz her yerde
            //Ya da tek bir yerde(ctur'da)

            #endregion

            //====================================================================================================
            //====================================================================================================

            #region inner type'larımız içerisindeki metotlara ulaşabilmek
            //nesne içindeki nesnenin metoduna ulaşacağız

            M1.musteriAdresleri[0].MusteriAdresTestMetot();

            #endregion

        }
    }
}
