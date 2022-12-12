using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Float
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Float nedir? 32 bitlik kayan noktalı değerleri saklayan değişkendir.
            //c# 'ta kayan noktalı değişkenlerimiz=double,flout ve decimal

            float number;
            number = 123;
            Console.WriteLine("Number= "+number);

            float number1;
            number1 = 12345678;
            Console.WriteLine(number1);

            float number2,number3;
            number2 = 1.2345670f;
            //sonuna f eklemezsek hata vericek.
            //7 basamaktan sonrasını yazdırmayacak floatda 7 basamak çalışır float!!
            Console.WriteLine(number2);

            number3 = 1.2345678f;
            //7. basamak sonrası 5'ten büyük olduğu için 7. basamağı yukarı yuvarladı.
            Console.WriteLine(number3);


            int x = 3;
            float y = 2.5F;
            int z = 4;
            float sum = 0F;
            sum = x + y + z;
            Console.WriteLine(sum);

            float i, j;
            i = Convert.ToSingle(Console.ReadLine());//kullanıcıdan değer alma float türü
            j = float.Parse(Console.ReadLine());
            Console.WriteLine(i);
            Console.WriteLine(j);



            Console.ReadLine();
        }
    }
}
