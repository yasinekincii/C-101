using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_decimal_float
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double 

            double doubleVal1 = 10.2;
            double doubleVal2 = 10; //double tipi int tipinden büyük olduğu için tam sayı da saklayabiliyoruz double değişkeni altında
            double doubleVal3 = 10.9d;//double değişken tipinde sonundaki son ek zorunlu değildir.

            double doubleMinValue = double.MinValue;
            double doubleMaxValue = double.MaxValue;


            //decimal

            decimal decimalVal1 = 10.2M;//decimal değer tanımlayabilmen için sonuna M koyman gerekiyor.

            decimal decimalMinValue = decimal.MinValue;
            decimal decimalMaxValue = decimal.MaxValue;


            //Float

            float floatVal1 = 10.2F;//Float kullanmak istiyorsan sonuna F koyman gerekiyor.

            float floatMinValue = float.MinValue;
            float floatMaxValue = float.MaxValue;


        }
    }
}
