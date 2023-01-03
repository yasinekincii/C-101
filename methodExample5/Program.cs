using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodExample5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bu yazımızda C# ile Parametre olarak Dizi değişken alan metotlara örnek olarak, ana programda rasgele sayılar vererek oluşturmuş olduğumuz sayilar dizisini Topla ve Ortalama isimli metotlara gönderceğiz. Ana programda oluşturacağımız dizi 20 elemanlı olacak ve içine 1-100 arası rastgele değerler  girilmiş olacak. Topla isimli metodumuz dizi türünden parametre alarak int türünden değer döndürecek. Yine aynı şekilde Ortalama isimli metodumuzda dizi türünde parametre alarak geriye farklı olarak double türünde bir değer döndürecek.

            Random rnd = new Random();
            int[] db = new int[5];

            for (int i=0;i<db.Length;i++)
            {
                db[i] = rnd.Next(0,100);
            }

            Console.WriteLine("Dizideki elemanların toplamı: "+Topla(db).ToString());

            Console.WriteLine("Dizideki elemanların ortalaması: "+Ortalama(db).ToString());

            Console.ReadLine();


        }


        static int Topla(params int[] tp)
        {
            int toplam = 0;
            for (int i=0;i<tp.Length;i++)
            {
                toplam += tp[i];
            }
            return toplam;
        }

        static double Ortalama(params int[] db)
        {
            double toplam = 0;
            for(int i = 0; i < db.Length; i++)
            {
                toplam += db[i];
            }
            return toplam/db.Length;
        }
    }
}
