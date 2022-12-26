using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //classlar bir programlama dilinde en çok kullanılan nesnelerdir.
            //classlar aslında bir paket gibi çalışır içerisine birden fazla birden farklı türde nesne alabilen ve bunları işlevsel olarak kullanabilmek için topladığınız işlevselleştirebildiğiniz bir nesne yapısıdır.

            //class içerisinde değişkenler nesneler metotlar tanımlayabiliyorsunuz

            //Kutu sınıfının nesne örneğini üretelim
            //parantez aç kapa varsa o bir metottur demiştik.Peki bu parantez aç kapa nereden geliyor=constructor methottan
            //constructor metot bizim oluşturduğumuz sınıfın nesne örneğini üretmek için oluşturulan bir metottur.

            //biz constructor oluşturmazsak derleyici kendisi bir constructor metot oluşturur.
            //eğer biz bir constructor metot oluşturursak ise derleyicinin kendisi constructor metot oluşturmaz.

            Kutu k = new Kutu();
            //Console.WriteLine(k.uzunluk);


            //Boş Constructorı kapatırsam(1 tane parametreli kaldı).Biz de şimdi nesne oluşturduğumuzda parametre eklemezsek program parametre istiyorum diye hata vericek
            //c# derleyicisi biz constructor oluşturana kadar(parametreli veya parametresiz)kendisi arka planda boş bir constructor oluşturuyor.Ama biz herhangi bir parametreli veya parametresiz bir constructor yazarsak artık kendisi üretmez



            k.SetUzunluk(90);//set yöntemini kullandık.
            Console.WriteLine(k.GetUzunluk()); //değeri aldık.//get değerini kullandık.


            k.Genislik = 30; //k. dediğimde genişlik diye siyah bir anahtar çıktı bu pro? simgesidir.Bunu kullanabilirsiniz
            //bu kullanımda get veya setten herhangi birisini yorum satırına alırsam k.genişlik kızarıcak
            Console.WriteLine(k.Genislik);









            Console.ReadLine();
        }
    }
}
