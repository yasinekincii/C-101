using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function3
{
    internal class Program
    {
        private static int Topla(int s1,int s2) //toplaya bir değişken verdim.
        {
            int t = s1 + s2;
            return t;
        }
            
        
        static void Main(string[] args)
        {
            //toplama işlemini bir metotla yaptıralım.

            Console.WriteLine("Toplam: " + Topla(5, 6)); //artı koyup to yazdığımda aşağıda toplam çıkıyor.Başındaki küp işareti fonksiyon olduğuna işaret ediyor.Altındaki kilit ise private olduğuna
            Console.WriteLine("Toplam: "+Topla(9,9));

            Console.Read();
        }
    }
}
