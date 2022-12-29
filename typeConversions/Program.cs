using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typeConversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bilinçli tür dönüşümleri
            //sayısal değişkenler içerisinde olan dönüşümü inceliyor olacağız

            byte sayi1 = 100;
            
            //byte değişkeninin sınırlarını öğrenelim
            byte byteMin = byte.MinValue;//0
            byte byteMax = byte.MaxValue;//255

            //sayi1 = 256; diyemeyiz benim sınırlarım belli ben bu değeri taşıyamam diyor.

            int sayi2 = 256;
            //int'nin min,max değeri byte'a göre daha yüksek
            int intMin = int.MinValue;
            int intMax = int.MaxValue;

            int sayi3 = sayi1;//sayi3'ün içerisindeki 100 değerini değişken tipi byte olan bir değişkenin içerisindeki değeri int'a atarak verdik.Türler arası geçiş yapımış olduk.


            //byte değişken tipinde olan bir değişkenin içindeki değeri int değişken tipinde olan farklı bir değişkenin içerisine aktardım.
            //uygulama şöyle düşünüyor: benim karşıma gelen değişken nedir =sayi1 tipi nedir =byte
            //int diyor ki byte'ın diyor alabileceği min value kaç 0 ,max değer kaç diyor 255 benimkilerden düşük ben bytedan büyüğüm diyor.Byte'ın içerisinde ne olursa olsun int hata vermem diyor
            //ben bu değeri saklayabilirim diyor ve içerisine alıyor ve bu davranışın adı bilinçli tür dönüşümü.

            //int sayi1'e bakmıyor değişken tipine bakıyor.Endüşük ne alabilir en yüksek ne alabilir ben en düşük ne alırım en yüksek ne değeri alırım
            //ben byte'ı taşıyabilir miyim aslında buna bakıyor

        }
    }
}
