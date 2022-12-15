using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeNowFunction2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //c#console da bazı harfler var harfler kısaltılıyor.Kısaltılan harfler bir şeylerin karşılığı oluyor.
            //küçük d harfi kısa tarihin karşılığı oluyor.
            //Büyük D harfi de uzun tarihin karşılığı oluyor.
            //küçük f harfi full tarih=Gün/Ay/Yıl saat/dakika/saniye
            // g harfi kısa tarih uzun zaman
            //m month
            //r ay
            //t sadece saat

            DateTime zaman;
            zaman = DateTime.Now;

            Console.WriteLine("Kısa Tarih: {0:d}",zaman);//0 zamanı aldı.Onun yanına d harfi ekledik onu d formatında yazıcak
            //d formatım zamanı yazdırıyor.Saatten bağımsız yazdırıyor sadece gün,ay,yıl formatında yazdırıyor.

            Console.WriteLine("Uzun Tarih: {0:D}",zaman);//D olarak eklediğimizde ayı yazıyla yazdı.ve günü de ekledi

            Console.WriteLine("Tam tarih: {0:f}",zaman);//D ye ek olarak saati ve dakikayı koydu.

            Console.WriteLine("Tam tarih 2: {0:F}",zaman);//bunda ise saniye de eklendi.

            Console.WriteLine("Sayısal Tarih Formatı: {0:g}", zaman);
            Console.WriteLine("Sayısal Tarih Formatı 2: {0:G}", zaman);

            Console.WriteLine("Ay:{0:M}",zaman);//ilgili ayı ve ayın kaçıncı günü olduğunu bize verdi
            //küçük m ile büyük m arasında fark yok


            Console.WriteLine("Biçim:{0:r}", zaman);
            Console.WriteLine("Biçim:{0:s}", zaman);
            Console.WriteLine("Saat:{0:t}", zaman);
            Console.WriteLine("Saat+sn:{0:T}", zaman);
            Console.WriteLine("ay,yıl:{0:y}", zaman);







            Console.Read();
        }
    }
}
