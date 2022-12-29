using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesExamples4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Soru1: String olarak verilen değeri bool tipine dönüştürün
            string metin1 = "true";
            bool b1 = Convert.ToBoolean(metin1);
            bool b2 = bool.Parse(metin1);


            //soru2: int içerisinde olan 100 değerini byte ve float değişken tiplerine dönüştürün
            int s1 = 100;
            byte sb2 = Convert.ToByte(s1);
            byte sb3 = (byte)s1;//bilinçsiz tür dönüşümü
            float f1 = s1;//float daha büyük bir değişken old için herhangi bir sıkıntı çıkarmayacaktır.

            //soru3:Byte değişken içerisinde olan tipi Decimal değişken tipine dönüştürün
            byte b3 = 10;
            decimal d1 = b3;




            Console.ReadLine();
        }
    }
}
