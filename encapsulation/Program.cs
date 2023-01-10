using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            

            /*
             *  Müşteri classı içerisinde tanımlamış olduğumuz fieldları özelleştirebilmek için biz aslında kapsüllemeyi kullanırız
             *  
             *  
             *  Field içerisine değer ataması yapılamasın ama değer okunabilsin
             *  Field içerisine değer ataması yapılsın ama değer okunamasın
             *  field içerisine değer ataması yapılsın ama değerin ilk 4 hanesi okunsun
             *  Field içerisine değer ataması ve okuma işlemleri yapılsın ama bu iki işlem de bizim belirlediğimiz bir süreçten geçsin veri daha sonra gösterilsin
             */

            /*
             * Özetle: Class'ın içerisinde bir fieldın değer alma ve değer okuma kısımlarına müdahale ettiğimiz noktalara biz encapsulation(kapsülleme) diyoruz.
             */


            /*
             * Class
             * Field
             * Property(özellik) içerisinde  => Get&Set bloklarımızı inceleyeceğiz 
             */


            //M1.emailAdres = "yekinci@hotmail.com";(Field)
            #region Field değer ataması yaptık ve değeri okuduk.

            //M1.EmailAdres = "yekinci@hotmail.com";        son örnek için yorum satılarına aldım.
            #endregion


            #region Field değer ataması yapılamasın ama değer okunabilsin
            Console.WriteLine("Müşteri id değeri:"+M1.ID);
            //M1.ID = 10; set private old için değer atayamam


            #endregion

            #region example

            M1.TCKimlikNumarasi = "12345678911";

            #endregion


            #region Son kısım

            //isim ve soyisim
            //email adresi..
            //email get cengiz.atilla@hotmail.com
            //set:private

            M1.isim = "ahmet";
            M1.Soyisim = "inanç";
            Console.WriteLine(M1.EmailAdres);

            #endregion


            Console.ReadLine();
        }
    }
}
