using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exampleTax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir ürünün kdv eklenmiş fiyatını bulalım

            Console.WriteLine("Kdv eklenmesini istediğiniz ürünün fiyatını giriniz");
            int price = Convert.ToInt32(Console.ReadLine());

            if (price>=0)
            {
                Console.WriteLine(price * 1.18);
            }
            else
            {
                Console.WriteLine("Hatalı bir giriş yaptınız");
            }
            

            Console.ReadLine();
        }
    }
}
