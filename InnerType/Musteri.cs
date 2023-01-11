using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    public class Musteri  //Musteri adında bir nesne oluşturuyorum.
    {
        #region     Tekil olarak kullanılan field

        public int musteriID { get; set; }
        public string tcKimlikNumarasi { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime olusturmaTarih { get; set; }
        public int kullaniciId { get; set; }
        #endregion

        //====================================================================================================
        //====================================================================================================

        #region     Inner Type gerektiren field'lar

        //Benim müşterimin birden fazla adresi olabilir  ben burada fieldlar ile değerleri yazarsam belirli bir adet kadar müşteri almış olurum.
        //public string adresTip { get; set; }
        // public string il { get; set; }
        //public string ilce { get; set; }
        //public string adres { get; set; }
        //Bu şekilde bir tanım yaptığımızda müşterinin en az 5 tane adresi olduğunu düşünürsek adres tip1,adres tip2 gibi farklı farklı bölümlerle içeride kendini tekrar eden field blokları oluşturmak zorundayız bu tarz kullanım yerine aslında modellemek istediğimiz konu şu MÜŞTERİADRES adında bir tip oluşturmak burada oluşturmuş olduğumuz adresTip,il,ilce,adres bilgisini MÜŞTERİ ADRES NESNESİ İÇERİSİNE AKTARMAK ve MÜŞTERİ nesnemizin içerisinde bir koleksiyon olarak adresimizi tanımlamak(bu yöntemle inner type kullanımını gerçekleştireceğiz)

        public MusteriAdres[] musteriAdresleri;    //Müşteri nesnemizin içerisinde müşteriadres nesnemizi bir koleksiyon olarak tanımlamış olduk.Benim Müşteri nesnem birden fazla müşteri adresini bu şekilde barındırabilicek
       
        public MusteriIletisimBilgisi[] musteriIletisimBilgileri;
        public MusteriSiparisBilgisi[] musteriSiparisBilgileri;

        #endregion

        //====================================================================================================
        //====================================================================================================

        //Constructor 
        public Musteri()
        {
            musteriAdresleri = new MusteriAdres[5];
            musteriIletisimBilgileri = new MusteriIletisimBilgisi[3];
            musteriSiparisBilgileri = new MusteriSiparisBilgisi[10];
        }

    }
}
