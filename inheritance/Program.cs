using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inheritance=(KALITIM/MİRAS)

            //mesela siz bir class geliştirdiniz.Bu class içerisindeki özellikler genel 
            //olarak bir çok alanda kullanılabilir o zaman her ihtiyacımız olduğunda
            //bu class içerisindeki bütün tanımlamaları ve metotları ve algoritmaları 
            //tekrar tekrar yazmak tamamen gereksizdir..(kod kalabalığı)

            //sen bir şey yazdıysan ve bu başka bir şeye kalıtım verebilir durumdaysa
            //bir başka şey bu bahsettiğimiz nesnenin içerisindeki şeyler muhtaçsa onu üzerine
            //ekleyerek bir şeyler geliştirebilicekse o zaman bu sınıftan miras al onun
            //içerisindeki her şeye eriş onu kullan ama yeni bir sınıfta kullan


            A a = new A();
            a.PropA = 5;

            B b = new B();
            b.PropB = 3;
            b.PropA = 8; //B classında B:A yaptğım için PropA yı kullanabiliyorum.

            C c = new C();
            c.PropC = 1;


            Console.ReadLine();
        }

        class A     //Base(Temel Sınıf)
        {
            public int PropA { get; set; }
        }


        class B:A //ben B sınıfı olarak A sınıfındaki PropA yı kullanmak istiyorum.
        {//B A'ya göre Derived,türemiş sınıf(B A'dan türemiş)
            public int PropB { get; set; }
        }


        class C:B //B Sınıfı zaten A sınıfını miras ald için sadece B yazarak PropA ve PropB ye ulaştık.
        {//B C'ye göre Base sınıftır.
            //C ise B'ye göre B'den türemiş bir sınıftır.
            public int PropC { get; set; }
        }
    }
}
