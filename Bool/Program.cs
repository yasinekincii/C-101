using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool değişkeni koşullu yapılarda kullanılan mantıksal değişken.
            int number;
            Console.WriteLine("Bir sayı Giriniz: ");
            number = Convert.ToInt32(Console.ReadLine());

            bool situation1 = number > 0;
            bool situation2 = number > 10;

            Console.WriteLine("Sayı pozitif mi {0}",situation1);
            Console.WriteLine("Sayı 10'dan büyük mü {0}",situation2);

            //küp metot olduğu anlamına gelir.Metotların sonuna parantez açıp kapatmamız gerekir.

            Console.Write("\nŞifrenizi girin=");
            String password;
            password = Console.ReadLine();
            bool x = password == "1234";

            Console.WriteLine("Şifre Doğru Mu? {0}",x);
    


            Console.ReadLine();
        }
    }
}
