using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mod alma operatörü %

            int s1 = 10, s2 = 2;
            int sonucMod = s1 % 2;


            //++ operatörü
            int s3 = 10;
            int operatorsonuc1 = (s3++); //önce s3 değerini operatorsonuc1'e aktarıyor sonra s3 değerini 1 arttırdı. (operatorsonuc=10)(s3=11) oldu.(önce değeri atadı sonra atama işlemi yaptı)
            int operatorsonuc2 = ++s3; //eğer sol taraftaysa önce değerleri toplar sonra atama işlemini yapar(operatorsonuc2=12)(s3=12)


            //-- operatörü
            int s4 = 10;
            int operatorsonuc3 = s4--;
            int operatorsonuc4 = --s4;
        }
    }
}
