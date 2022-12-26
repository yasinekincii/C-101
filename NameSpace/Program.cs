using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSpace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NameSpace=
            //namespaceler c#'ta projeyi derli toplu paket mantığıyla yönetebilmek için kullanılır.Yani siz bir proje açtığınız zaman bu solution içerisinde açılır ve solution otomatik olarak size bir namespace atar

            ProjectA.TeamA.ClassA sinif1 = new ProjectA.TeamA.ClassA();
            sinif1.Yaz();
            ProjectA.TeamA.ClassA.Print();//böyle yapsaydım static'e erişecektim

            //dikkat edersen projecta.teama uzun uzun yazılıyor bunun yerine

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
