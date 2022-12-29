using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Çarpma operatörü
             *  sayısal işlemler yapabildiğimiz değişken tiplerinde çarpma işlemini sağlıyor ve sonucunu bize veriyor
             * 
             */

            double d1 = 10.4;
            double d2 = 10.6;
            double sonuc = d1 * d2;

            int sonucInt = (int)(d1 * d2);
            int sonucInt1 = (int)sonuc;

            int sonucInt2 = Convert.ToInt32(d1*d2);



        }
    }
}
