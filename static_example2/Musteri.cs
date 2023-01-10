using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_example2
{
    internal class Musteri
    {
        public static ArrayList musteriDataBase;

        //================================================================
        //================================================================

        #region Field

        public int ID { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        private string _emailAdres { get; set; }
        private string _kullaniciAdi;
        private string _Sifre;

        #endregion
        //================================================================
        //================================================================

        #region Encapsulation

        public string KullaniciAdi
        {
            set
            {
                if (musteriDataBase.Contains(value))
                {
                    Console.WriteLine("Girilen kullanici adı sistemde mevcur başka bir kullanici adi giriniz..");
                }
                else
                {
                    musteriDataBase.Add(value);
                    this._kullaniciAdi = KullaniciAdi;
                }
            }
            get
            {
                return this._kullaniciAdi;
            }
        }

        public string EmailAdres
        {
            set 
            {
                if (musteriDataBase.Contains(value))
                {
                    Console.WriteLine("Girilen mail adresi sistemde kayıtlıdır lütfen tekrar deneyiniz");
                }
                else
                {
                    musteriDataBase.Add(value);
                    this._emailAdres = EmailAdres;
                }
                
            }
            get 
            {
                return this._emailAdres;
            }
        }

        #endregion

        //================================================================
        //================================================================


        #region STATİC YAPICI METOT
        static Musteri()//static yapıcı metodu
        {
            musteriDataBase = new ArrayList();
        }
        #endregion


        //================================================================
        //================================================================

        #region Static metot

        public static void MusteriEkle(Musteri MM)
        {
            if (MM.Equals(null))
            {
                Console.WriteLine("Müşteri nesnesi nulldır.");
            }
            else
            {
                if (MM._kullaniciAdi == null)
                {
                    Console.WriteLine("Kullaniciadi değeri nulldır.");
                }
                else
                {
                    if (musteriDataBase.Contains(MM.EmailAdres))
                    {
                        Console.WriteLine("Girdiğiniz mail adresi sistemde kayıtlıdır.");
                    }
                    else
                    {
                        musteriDataBase.Add(MM);
                    }

                }
            }

        }


        #endregion

    }
}

