using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro
{
    internal class Musteri
    {
        //müşteri tanımım içerisinde müşterimin temel ihtiyaçlarını saklamak istiyorum

        /*
         * TC Kimlik Numarası
         *  Isim 
         *  Soyisim
         *  Cinsiyet
         * 
         */

        //Yapıcı Metot ctor
        public Musteri()//MÜŞTERİ NESNEM OLUŞURKEN DİLERSEN BOŞ BIRAK DEFAULT DEĞERLERİ İLE OLUŞSUN
        {
            //nesnelerimizi örneklerken içerisinde bulunan fieldların bir değer alması gerekiyor.Bu değer alma zorunluluğu .net içerisinde yapıcı metotlarla sağlanıyor eğer biz bu yapıcı metotlara müdahale etmezsek arka tarafta kodumuz çalışırken bu metodlar bizim için oluşuyor ve boş bir şekilde duruyor
            //Ne yapıyor? classın içerisinde duran classın içerisinde varlığını koruyan fieldların veri tiplerine göre default değerler veriyor.Classın içerisindeki fieldlar default değerlerini aldıktan sonra işlem yapabilir hale geliyor ve dinlemeye başlıyor içerisine bir değer gelicek mi bir işlem olucak mı diye sistem bizim o class'ı kullanabilirliğimizi açıyor.Biz eğer yapıcı metotlara müdahale edebilirsek sistemin default değerlerini değiştirebiliriz.

            tcKimlikNumara = "12345"; //dediğimde tckimlik numarası default değere değil benim vermiş olduğum değere sahip oldu
        }

        public Musteri(string _TCKimlikNo)//DİLERSEN TCKİMLİK NUMARASINI AL
        {
            tcKimlikNumara = _TCKimlikNo;
        }

        public Musteri(string _TCKimlikNo, string _isim)//TCKİMLİK İSİM
        {
            tcKimlikNumara = _TCKimlikNo;
            isim = _isim;
        }

        public Musteri(string _TCKimlikNo, string _isim,string _soyisim)//TC,İSİM,SOYİSİM DEĞERLERİNİ DE GİREREK SEN BU MÜŞTERİNİN RAME OLUŞMA AŞAMASINDA DEĞERLERİNİ ATAYABİLİRSİN
        {
            tcKimlikNumara = _TCKimlikNo;
            isim = _isim;
            soyisim = _soyisim;     
        }
        //Yapıcı metodumuzun 4 farklı kullanımını sisteme tanıtmış olduk

        public string tcKimlikNumara;
        public string isim;
        public string soyisim;
        public int cinsiyet;   //717770001:Bay   --  717770002:Kadın

        //Müşteri tanımımız tamamlandı.


        #region Sınıflarda Metotlar

            public bool MusteriKontrol()
        {
            bool kontrol = MusteriKontrolDataBase(tcKimlikNumara);
            return kontrol;            
        }

        private bool MusteriKontrolDataBase(string tc)
        {
            //database gidilir müşterinin tckimlik numarasına göre daha önce kayıt edilip edilmediği bilgisi sorgulanır
            return true;

        }


        internal void Deneme()
        {
            Console.WriteLine("İnternal= bu namespace içerisinde(herkes ulaşabilir) public demektir.");
            Console.WriteLine("Metodun yanında da kalp ikonu çıkar");
            Console.WriteLine("public dediğimizde dışarıdan kim çağırırsa çağırsın herkese açık bir yapıdır.");
        }

        #endregion









    }
}
