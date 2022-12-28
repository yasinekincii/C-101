using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             C# dilinde "enum" Yapısı bu yapı yazılım dilinde enum,enumaration ya da enum sabitleri olarak adlandırılır.
            Değişkenlerin alabileceği değerlerin sabit(belli) olduğu durumlarda programı daha okunabilir hale getirmek için kullanılır.
            Programda birçok değişkene tek tek sayısal değer vermek yerine "enum" kullanılabilir.
             */

            //nasıl kullanılır
            Console.WriteLine(Yetki.Admin);//adminin üzerine geldiğimde =sayı gördüm

            var id = (int)Yetkili.Admin;//intek cast ettik
            Console.WriteLine(id);


            Console.ReadLine();
        }
    }

    //class dışarısında yazıcağız
    enum Yetki
    {
        Normal,
        Moderator,
        Editor,
        Admin,
        SuperAdmin
    }

    //yukarıdaki gibi kullandığımızda program değerleri kendisi bir sayı atar bunu kendimiz de yazabiliriz

    enum Yetkili
    {
        Normal=3,
        Moderator=4,
        Editor=6,
        Admin=7,
        SuperAdmin=9
    }

    enum OnayDurum
    {
        OnayBekliyor=1,
        Onaylandi=2,
        Reddedildi=3
    }
}
