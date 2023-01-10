using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_
{
    public class Student    //internal da olabilir
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }     //prop tab tab yaparak hızlıca yazabilirim.


        public void Test1()
        {
            Console.WriteLine("Nesne örneği alındıktan sonra çalışan metot");
            Test2();
            //Static olmayan bir metot static olan bir metodu çağırabilir.
        }

        public static void Test2()
        {
            Console.WriteLine("Nesne örneği alınmadan kullanılabilir.");
            //Test1();
            //static olan bir metot static olmayan bir metotu vb. çağıramaz
            //Bu kuralın sebebi: Static olmayan bir nesneyi çağırabilmesi için öncelikle o nesnenin nesne örneğine ulaşması gerekiyor ki static kavramının dışında bir olaydır bu static bununla ilgilenmez

        }

    }
}
