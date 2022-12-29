using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //çıkartma operatörü(-)
            //sayısal değişken tiplerinde çalışıyor(byte,int,double,float,decimal)

            int s1 = 100;
            int s2 = 50;
            int sonuc = s1 - s2;

            byte b1 = 100;
            byte b2 = 50;
            var sonucByte = b1 - b2;//byte için sınırlarını geçme ihtimalimiz çok yüksek old için geri dönüş tipini otomatik olarak int atıyor.



        }
    }
}
