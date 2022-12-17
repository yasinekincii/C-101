using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function3
{
    internal class Program
    {
        //void: Geçersiz,içi boş anlamlarına geliyor.Herhangi bir değişken almayan yapılar için kullanıyorduk.
        //Şimdi bir değişken kullanacağız.Kullanacağımız değişken ne? int türünden bir toplama işlemi
        private static int Topla(int s1,int s2) //topla adında İNT türünden bir değişken oluşturdum.
        {
            int t = s1 + s2;
            //t'yi geri döndürmem gerekiyor.Geriye değer döndüren metotlar
            //kullanıcıya geri değer döndüren bir uygulamadan bahsediyorum.O yüzden return ifadesi kullandım.
            return t;
        }
            
        
        static void Main(string[] args)
        {
            //toplama işlemini bir metotla yaptıralım.

            Console.WriteLine("Toplam: " + Topla(5, 6)); //artı koyup to yazdığımda aşağıda toplam çıkıyor.Başındaki küp işareti fonksiyon olduğuna işaret ediyor.Altındaki kilit ise private olduğuna
            Console.WriteLine("Toplam: "+Topla(9,9));//Topla yazınca ctrl+space ile çıkan küp bunun bir metot olduğunu gösterir.Altında olan kilit ise private olduğunu gösterir.

            Console.Read();
        }
    }
}
