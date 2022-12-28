using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//using ile başlayan bölümler ise seçmiş olduğumuz .netflamework'un versiyonuna göre değişkenlik
//gösteren ve hali hazırda gelen kütüphanelerdir.

namespace ConsoleWriteRead//isim uzayı olarak geçer.İçerisinde class'ları barındırır.
{
    internal class Program //OOP'nın temelini oluşturan bölümdür.
    {
        static void Main(string[] args)
        {
            //ekrana kullanıcının görmesi için bir yazı yazdırmak istediğimizde biz bu komutları çağırırız.

            Console.Write("Merhaba Dünya ");
            //Çalıştırdığımızda ekrana Merhaba Dünya yazdı ve yazının sonunda yanıp sönen bir imleç var
            //console.write ile biz bu işlemi yaptığımızda mesajımızı yazar. ikinci bir mesaj yazmak istediğimizde
            //imleç yazının yanında bekler ve diğer yazıyı da onun yanına devam ederek yazar

            Console.Write("Fenerbahçe");//bunun çıktısı merhaba dünya fenerbahçe şeklinde olucaktır var imleç
            //fenerbahçenin sonunda yanıp sönücektir.Bu da bir daha bir şey gelirse ben yazmaya buradan başlarım demek oluyor

            //özetle console write mesajı yazar.Yazdıktan sonra da imleçi yanında bekletir.
            Console.WriteLine();

            Console.WriteLine("Merhaba Dünya "); //yine ekrana bir yazı yazıcak ama bu sefer imleç dünyanın yanında beklemiyor
            //bir alt satırda hazır olarak bekliyor.Demek ki Console.writeLine yazarsam ilgili mesajı yazıcak ve alt satıra geçicek
            

            //özetle write dediğimiz zaman mesajı yazar imleçi yanında bekletir.
            //writeline diye bunu belirtirsek mesajımızı yazar ve bir alt satıra geçer

            Console.ReadLine();
            //ReadLine komutunu çağırdığımızda aslında bu komut şunu söylüyor console.readline komutu
            //olarak console uygulamalarda kullanıcıdan değer beklerim diyor.Değeri girip enter a bastığımız an
            //kapanıcak           
           
        }
    }
}
