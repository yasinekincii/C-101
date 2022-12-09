using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string isim;
            isim = "mehmet";

            if (isim == "mehmet"){
               Console.WriteLine("Doğru isim Girişi");
            }
            else {
                Console.Write("Hatalı isim");     
            }


            string name;
            Console.WriteLine("İsminizi girin");
            name = Console.ReadLine();

            if (name == "baran"){
                Console.Write("Doğru isim girişi");
            }
            else {
                Console.WriteLine("Hatalı giriş yaptınız");
            }

            Console.Read();
        }
    }
}
