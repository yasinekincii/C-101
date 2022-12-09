using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ali amca dükkanından 100 liraya kadar alışveriş yaparsanız%10 indirim yapıyor.100 ile 150 lira arasına %15 indirim 150 ile 200 arasına %20 indirim yapıyor.
            //dükkandan kitap alan kişilerin ödemesi gerken fiyat tutarlarını bulan programı gerçekleştir.

            double price,price2;
            Console.WriteLine("Kitabın fiyatını giriniz");
            price = Convert.ToDouble(Console.ReadLine());
            price2 = price;

            if (price < 100)
            {   
                price = price * 0.9;
                Console.WriteLine("İndirim miktarı="+(price2-(price2*0.9)));
                Console.WriteLine("Kitabın %10 indirimli fiyatı= "+price);

            } if(price>=100 && price < 150)
            {
                price = price* 0.85;
                Console.WriteLine("İndirim Miktarı="+(price2-(price2*0.85)));
                Console.WriteLine("Kitabın %15 indirimli fiyatı= "+price);

            } if(price>=150 && price < 200)
            {
                price = price * 0.8;
                Console.WriteLine("İndirim Miktarı= "+(price2-(price2*0.8)));
                Console.WriteLine("Kitabın %20'i indirimli fiyatı= "+price);
            }


            Console.ReadLine();
        }
    }
}
