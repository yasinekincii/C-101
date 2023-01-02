using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodExample
{
    public class Mathematics //başına public koyarak mathematics class ımız dış dünyada erişilebilir olsun diye 
    {

        //toplama
        public decimal sum(decimal number1,decimal number2)
        {
            return number1 + number2;
        }

        //çıkartma
        public decimal minus(decimal number1,decimal number2)
        {
            return number1 - number2;       
                       
        }

        //bölme
        public decimal divide(decimal number1,decimal number2)
        {
            return number1 / number2;
        }

        //çarpma
        public decimal muplication(decimal number1,decimal number2)
        {
            return number1 * number2;
        }

        public void menu()
        {
            Console.Clear();
            Console.WriteLine("***Menü***");
            Console.WriteLine("1-Toplama");
            Console.WriteLine("2-Çıkartma");
            Console.WriteLine("3-Çarpma");
            Console.WriteLine("4-Bölme");
            Console.Write("Lütfen değer seçiniz: ");
        }

        public void sonucEkranaYaz(decimal kullaniciSayi1, decimal kullaniciSayi2, decimal sonuc,string operat)
        {
            Console.WriteLine("{0} {1} {2} = {3}",kullaniciSayi1,operat,kullaniciSayi2,sonuc);
        }

      
    }
}
