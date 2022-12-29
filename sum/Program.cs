using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ilk operatörümüz toplama operatörü
            //+
            //int+int(Toplama işlemi yapar)

            int s1 = 10, s2 = 15;
            int toplamInt = s1 + s2;

            byte s3 = 10;
            byte s4 = 10;
            int toplamByte = s3 + s4; //2 byte'ı topladığınız zaman size dönen değer int oluyor
            //ben 2 byte top geri byte vermem int veririm diyor çünkü byte'ın max değeri 255 old için sen bunu hızlıca geçebilirsin diyor

            //+ operatörünün sağına ya da soluna string gelirse + operatörümüz string birleştirme yapar.

            //string+int
            string metin1 = "merhaba";
            int s5 = 10;
            string toplamStr1 = metin1 + s5;//toplama operatörü aslında string birleştirme işlemi yapıyor


            //int+string
            string toplamStr2 = s5 + metin1;


            //string+string
            string metin2 = "dünya";
            string toplamStr3 = metin1 + metin2;

            Console.ReadLine();

            //diğer operatörlerde aritmetiksel değişken tipleri üzerinde çalışırlar.Bu davranışlar + operatörüne özledir.
        }
    }
}
