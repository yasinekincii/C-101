using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booleans
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mantıksal değerlerimizi tutabiliceğimiz bir Değişken

            /*  yasin.ekinci
             *  1
             *  Giriş Yap
             *  
             *  Değerleri Kullanıcıdan al
             *  Değerleri değişkenlere kayıt et
             *  Değerleri kontrol et(kullanıcı adı,şifre girilmiş mi)
             *  Değerleri veri tabanından doğrula!
             *  Evet=>true
             *  Hayır =>false
             *  evet ve hayırın saklandığı değişken tipi= bool 
             *  
             *  Bir değişken tanımladım alıcağı default dediğimiz değer burada false olarak gelir. 
             */

            bool kullaniciSonuc = true;
            kullaniciSonuc = false;

            bool kullaniciDeger; //kullanıcıDeger diye bir değişken oluşturdum içerisinde falsa var.Sistem boolean değişkeni tanımladıktan sonra içerisine herhangi bir değer almadıysa o zaman içerisine default olarak false veriyor
            kullaniciDeger = true;
        }
    }
}
