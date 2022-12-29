using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typeCoversations2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bilinçsiz tür dönüşümü

            //büyük olan tipin içindeki değeri küçük olan tipin içindeki değere atamaya çalışacağız

            //biz burada uygulamaya diyoruz ki bunun içindeki veriye ben kefilim sen dert etme bunun içerisindeki data benim bildiğim bir data maxı budur sen diyoruz al bunu içeri
            //bu yöntemde uygulamaya sözü biz veriyoruz.

            int sayi1 = 100;
            int intMin = int.MinValue;
            int intMax = int.MaxValue;

            // byte sayi2 = sayi1;
            //programımız hata veriyor? sebebi ise byte bakıyor int alabileceği en düşük değer ne -210.. max değer ne o da yüksek sonra diyor ki ben min 0 max 255 alabiliyorum.
            //Yani intte 256 değeri olsa ben hataya düşerim  diyor ama diyor ki sen bana bunun sözünü verirsen ben bunu kendi içime alabilirim senin sözüne güvenirim
            //değer taşıyabileceğimden fazla gelirse de hata veririm sorumluluk kabul etmem diyor

            byte sayi2 = (byte)sayi1; //parantezler içerisinde byte yazıyoruz sen bunu byte'a çevir diyorum içindeki değere ben kefilim diyorum.Eğer sayi1 içerisinde
                                      //senin sınırlarının dışarısında olan bir değer varsa hiç korkma hata ver diyoruz




        }
    }
}
