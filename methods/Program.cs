using System;//bir kütüphane dosyasını uygulamamızın içerisine eklemektir.
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//C# ile alakalı herhangi bir platformda bir uygulama açıyorsak usinglerin olduğunu göreceksin

//usingler nedir? .net flamework içerisinde kullanmış olduğumuz her komut bir kütüphaneden gelmekte(Console.WriteLine komutu => using system kütüphanesinden gelmekte)

//using blokları aslında temel olarak içeriye eklenmiş olan kütüphanelerdir.

//console uygulamalarında standart kütüphane system kütüphanesidir.Net flameworkte system kütüphanesi default olarak ekleniyor

namespace methods //bu namespace i başka bir uygulamada kütüphane olarak kullanabilirim
{//namespace tanımının bir kütüphaneye denk geldiğini anladık ve kütüphanelerimizin içerisinde classlarımızın olduğundan bahsettik

    //namespace içerisinde class tanımlarımız bulunur.Class tanımlarımız aslında bizim .Netflamework içerisinde c# .netflamework ile kodlama yaparken oluşturmuş olduğumuz içerisinde metotları ve birçok özelliği barındıran küçük paketlerimiz
    internal class Program
    {//classın içerisinde de birden fazla metot olabilir.Her metot kendisi çağırıldığında bir işlem yapar
        static void Main(string[] args)//program class ım içerisinde bir metod tanımı old görüyoruz
        {
            /*Main metodu:
             * main metodu bu ana kadar yapmış olduğumuz tüm uygulamalarımızın ana metodudur.
             * Console ve windows form uygulamalarımız arka tarafta başlangıç için uygulamanın ilk başlicağı metot olarak main metodunu tanır.
             * Maindeki scope um benim uygulamamın tüm kodlarını bir şekilde barındırır.Son scope a geldiğimde uygulamamdan artık çıkmış olurum                         
             */

            //uzun bir şekilde yazım
            System.Console.WriteLine("merhaba");
            //console bir sınıftır.
            //Metotlarımız sınıflar içerisinde barınıyor
            //sınıfın üzerinde namespace

            //system kütüphanesi using kısmı eklenirse uzun yazmamıza gerek kalmaz

            //using kısmında kütüphane eklenmiş hali ile yazımı
            Console.Write("merhaba");
        }

        static void HelloWorld() //void: Metot çalışıcak ama geriye herhangi bir değer dönmeyecek.
        {//parantezin içerisi boş olduğu için herhangi bir değer almayacak

            Console.WriteLine("Hello World");
        }
    }
}
