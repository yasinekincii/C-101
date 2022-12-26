using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PATA= ProjectA.TeamA; //BUNLARA TAKMA İSİM VERDİM
using PATB= ProjectA.TeamB;

namespace NameSpace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NameSpace=
            //namespaceler c#'ta projeyi derli toplu paket mantığıyla yönetebilmek için kullanılır.Yani siz bir proje açtığınız zaman bu solution içerisinde açılır ve solution otomatik olarak size bir namespace atar

            //ProjectA.TeamA.ClassA sinif1 = new ProjectA.TeamA.ClassA();
            //sinif1.Yaz();
            //ProjectA.TeamA.ClassA.Print();//böyle yapsaydım static'e erişecektim

            //dikkat edersen projecta.teama uzun uzun yazılıyor bunun yerine
            //yukarıda using olarak yazsam

            //ClassA cc = new ClassA();

            //cc.Yaz();

            //farklı namespaceler içerisinde 2 tane classA var yani burada sınıfların karışma ihtimali çok yüksek
            //projectA.TeamB yaptıktan sonra classA lar hata verdi referansları karıştı (team a ve team b içerisinde classlar mevcut hangisi)

            //o yüzden takma isim vericeğim bunlara
            //şimdi classA ları hiç tanımıtor

            PATA.ClassA cc = new PATA.ClassA();

            PATB.ClassA dd = new PATB.ClassA();



            Console.ReadLine();
        }
    }
}

namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("ProjeA,EkipA,SınıfA,print()");
            }

            public void Yaz()
            {
                Console.WriteLine("ProjeA,EkipA,SınıfA,Yaz()");
            }
        }
    }

    namespace TeamB
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("ProjeA,EkipB,SınıfA,print()");
            }
        }
    }


}


namespace ProjectB
{
    namespace TeamA
    {
        class ClassA
        {

            public static void Print()
            {
                Console.WriteLine("ProjeB,EkipA,SınıfA,print()");
            }
        }
    }
}
