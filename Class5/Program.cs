using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class5
{
    class insan
    {
        //2 tane kod öğreneceğiz virtual void override
        //virtual sanal anlamına geliyor.
        //void ise geçersiz boş anlamına geliyor

        public virtual void selamver()//insan sınıfımı virtual void ile geçersiz kıldım 
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Title = "polimorfizm";
            Console.WriteLine("22.12.2022");

        }

    }

    //class sınıfının dışına çıktık ve kalıtım kullanacağız.
    class Turk : insan
    {
        //kalıtımı sağladım ama ben bunu bozmak istiyorum.
        //public override geçersiz kılıyor.
        public override void selamver()//selamver'i geçersiz kıldım
        {
            Console.WriteLine("merhaba");//base i sildim kendi istediğim değeri girdim.
        }
    }


    class Fransız : insan
    {
        //public override geçersiz kıl
        public override void selamver()//neyi geçersiz kıl selamveri
        {
            Console.WriteLine("bonjour");

            
            //base.selamver();
        }
    }


    class English : insan
    {
        public override void selamver()
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine("hi");
            
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //polimorfizm:Kalıtım gibi bir sınıftan bazı değerleri almak istiyoruz.Ama her şeyi almak istemiyoruz bazılarını almak istiyoruz sadece.

            //insan ins = new insan();
            //ins.selamver();

            Turk trk = new Turk();
            trk.selamver();
            //insan sınıfındaki selam ver metodu içerisindekileri yapmadı.Türk sınıfı içerisindeki selam ver komutumu bana gerçekleştirdi.

            //çok biçimlililk buna deniliyor.Kalıtım yoluyla alıyoruz ama oradakileri değil de kendi istediğimiz şeyleri yapıyoruz.

            Fransız frs = new Fransız();
            frs.selamver();


            English eng = new English();
            eng.selamver();


            Console.Read();
        }
    }
}
