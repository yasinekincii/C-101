using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreachexamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Liste içindeki elemanlar yazdırma
            var names = new List<string>() { "Hayri", "Ufuk", "Recep" };

            foreach(var elements in names)
            {
                Console.WriteLine(elements);
            }

            //C# ta 10 elemanlı dizi içine kulanıcının 10tane şehir eklemesini sağlayan
            //Girilen baş harfe göre şehirleri listeleyen program

            string[] citys = new string[4];

            for (int i=0; i<4; i++)
            {
                Console.Write("Şehiri ekleyiniz= ");
                citys[i] = Console.ReadLine();
            }

            Console.Write("Baş harf giriniz= ");
            char x = Convert.ToChar(Console.ReadLine());

            foreach (var element in citys){
                if (x == element[0])
                {
                    Console.WriteLine(element);
                }
            }

            Console.ReadLine();
        }
    }
}
