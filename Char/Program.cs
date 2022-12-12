using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Char
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //char ile string farkı : String değerleri kullanırken çift tırnak içine yazıyorduk ,charda ise bu tek tırnak içinde
            //char 'da en fazla 1 karakter kullanabilirsin.
            char harf;  //harf benim char türünde bir değişkenim
            harf = 'G';
            Console.WriteLine(harf);


            char sex;
            Console.WriteLine("Cinsiyetinizi giriniz");
            sex = Convert.ToChar(Console.ReadLine());

            if(sex=='e' || sex == 'E')
            {
                Console.WriteLine("Cinsiyet erkektir.");
            }
            else if(sex=='k' || sex == 'b' || sex=='K' || sex=='b')
            {
                Console.WriteLine("Cinsiyet Kadındır.");
            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız.");
            }

            Console.Read();
        }
    }
}
