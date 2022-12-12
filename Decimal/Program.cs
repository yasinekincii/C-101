using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal number;
            number = 12345;
            Console.WriteLine(number);

            number = 12.345m;//ondalık olduğu durumda sonuna m eklemem gerekiyor.
            Console.WriteLine(number);

            /////////////////////////////////
            //küçük türü büyük türe uydurmamamız gerekiyor.
            decimal s1;
            int s2;
            decimal sum;

            s1 = 2.45M;
            s2 = 3;
            sum = s1 + s2;
            Console.WriteLine("Toplam değeri="+sum);






            Console.ReadLine();
        }
    }
}
