using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    internal class Student
    {
        // get:almak  
        //set:ayarlamak

        //GET o veriyi alıyor SET ise o veri üzerinde değişiklik yapıyor.
        //get ve set bloğu ne işe yarar? cevap: private değişkene erişip ona değer girmeyi sağlar

        //oluşturulan private alanlara kontrollü bir şekilde erişim sağlamak için property tanımlanmaktadır.(Property=Özellik)
        //bizim kullanacağımız propertyşer ne = GET VE SET blokları

        //prop yazıp 2 defa tab'a bastığınız zaman get,set bloğunun kullanış şekli geliyor.

        private string ad;
        private string soyad;
        private int yas;
        private string alan;


        //diğer alanımda kullanmak için public olması gerekiyor
    }
}
