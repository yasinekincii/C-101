using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hash_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable H1 = new Hashtable();
            /*
             * hashtable key ve value değerleri ile kendisini besliyor.
             * 
             * Belirtmiş olduğumuz key değerleri hashtable içerisinde benzersiz olmak zorundadır.Value değerleri için böyle bir zorunluluk yoktur.
             * 
             * key değerleri list içerisinde dataya ulaşmak için kullanacağımız anahtar kelimeler
             * 
             */

            #region Yeni Değer Ekleme

            H1.Add("Car", "Araba");//add dediğimde 1 tane object key,1 tane de object value giriyorum.
            //key: car  ,  value: araba
            H1.Add("House","Ev");

            H1.Add("Cars","Araba");
            //H1.Add("Cars", "Arabalar");   Key değeri benzersiz(unique)olmak zorundadır.
            #endregion

            #region Yardımcı Metotlar

            bool kontrol1=H1.Contains("House");//parametre olarak girmiş olduğumuz key değeri ilgili koleksiyon içerisinde var ise true yoksa false cevabını döndürür
            bool kontrol2 = H1.Contains("Door");

            //contains ve containskey aynıdır.Containskey de contains gibi koleksiyonun key değerine bakar ve mevcut ise aranan key değeri true değerini döner.

            bool kontrol3 = H1.ContainsKey("House");
            bool kontrol4 = H1.ContainsValue("Araba");

            H1.Remove("Cars");//koleksiyon içerisindeki verilen key değeri ve karşılığı gelen value değerlerini siler.
            int koleksiyonIcindekiToplamDeger = H1.Count;
            H1.Clear();//Koleksiyon içerisindeki bütün datayı temizleriz.

            #endregion


            Console.ReadLine();
        }
    }
}
