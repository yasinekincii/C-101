using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3
{
    internal class Program
    {

        //kapsülleme get ve set bloklarıyla yapılan işlemlerle aynı
        
        //kapsülleme nedir? değişkenleri ve verileri hatalı kullanım ve dış
        // etkenlerden korumaktır.

        //bir nesnenin dışta soyutlanıp içte işlem yapmasıdır kapsülleme
        //ya da başka kod ve sınıflar tarafından kullanılmaması için bariyer görevi görür
        static void Main(string[] args)
        {

            Emlak kdk = new Emlak();
            kdk.RENGI = "BEyaz";
            kdk.ODASAYISI = -4;
            kdk.SEMTI = "kadıköy";
            kdk.KATNOSU = 4;
            kdk.ALANI = -80;

            Console.WriteLine("Evin rengi= {0} \nOda sayısı= {1} \nSemt= {2} \nKaçıncı kat= {3}.kat\nAlanı= {4} metrekare",kdk.RENGI,kdk.ODASAYISI,kdk.SEMTI,kdk.KATNOSU,kdk.ALANI);
            
            Console.Read();
        }
    }
}
