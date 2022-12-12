using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //klavyeden 2 tane decimal değer girelim bunları bir mağazada ürünlerin satış adedini klavyeden girelim ve ürün fiyatıyla çarpıp hesaplayalım.

            decimal product1, product2, sum;
            int n1, n2;

            product1 = 14.85M;
            product2 = 21.48m;

            Console.Write("1. Ürünün Satış Miktarı: ");
            n1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("2. ürünün Satış Miktarı: ");
            n2 = Convert.ToInt16(Console.ReadLine());

            sum = product1 * n1 + product2 * n2;
            Console.WriteLine("Gün Sonunda Kasada Olması Gereken Para:"+sum+"TL'dir.");



            Console.ReadLine();
        }
    }
}
