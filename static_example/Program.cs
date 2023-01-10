using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //personelimizin nesne örneğini alalım
            Personel P1 = new Personel();   //1.static yapıcı metodu sonra standart yapıcı metod çalışacak

            P1.Isim = "Cengiz";
            P1.Soyisim = "Atilla";
            P1.Emailadres = "Cengiz.Atilla";
            P1.Cinsiyet = 717770001;

            Personel P2 = new Personel();//bu sefer ise static yapıcı metodum çalışmayacak(uygulama içerisinde 1 kere çalışır)Normal yapıcı metodum çalıştı ve işlemler tamamlandı.

            P2.Isim = "Cengiz";
            P2.Soyisim = "Atilla";
            P2.Emailadres = "Cengiz.Atilla";
            P2.Cinsiyet = 717770001;



            //Helper H1 = new Helper();
            //ilgili class'ım static olduğu için ben bu class'ın nesne örneğini alamam dolayısıyla static class'ların nesne örnekleri alınmaz kendi içlerinde ise sadece static olan fieldları ve metotları barındırırlar

            Helper.emailGonder("ik@"+Personel.domainAdres,"Yeni personel bilgilendirme",P1.Isim+P1.Soyisim);
            Helper.emailGonder("ik@firmam.com","Yeni personel bilgilendirme",P1.Isim+P1.Soyisim);


        }
    }
}
