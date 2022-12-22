using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    internal class Student
    {
        //get:almak  
        //set:ayarlamak

        //GET o veriyi alıyor SET ise o veri üzerinde değişiklik yapıyor.
        //get ve set bloğu ne işe yarar? cevap: private değişkene erişip ona değer girmeyi sağlar

        //oluşturulan private alanlara kontrollü bir şekilde erişim sağlamak için property tanımlanmaktadır.(Property=Özellik)
        //bizim kullanacağımız propertyşer ne = GET VE SET blokları

        //prop yazıp 2 defa tab'a bastığınız zaman get,set bloğunun kullanış şekli geliyor.

        //amaç değişkene erişimi kapatmak

        private string ad;
        private string soyad;
        private int yas;
        private string alan;

        //diğer alanımda kullanmak için public olması gerekiyor
        public String ADI
        {
            get { return ad; }//get ile de return ad kullanarak o adı okuma işlemi yaptım.
            set { ad = value; }//klavyeden girilen ad değerini set ile aktardım
        }

        public string SOYADI
        {
            get { return soyad; }
            set { soyad = value; }//soyad= klavyeden girilen value
        }

        public String ALANI
        {
            get { return alan; }
            set { alan = value; }
        }
        
        public int YASI
        {
            get { return yas; }
            set 
            {
                if (yas >= 18)
                {
                    yas = value;
                }
                else
                {
                    yas = 18;
                }
            }
        }
        //value: KLavyeden girilen değer

        
    }
}
