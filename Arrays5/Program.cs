using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dizideki sayıların faktöriyeli
            int[] numbers = { 1, 2, 3, 4, 5, 6,7 };
            int result=1;

            foreach (int j in numbers) 
            {
                result = result * j; 
            }
            Console.WriteLine("Dizideki sayıların çarpımı= "+result);


            Console.Write("*********");
            //dizideki elemanları kendimiz gireceğiz sonrasında da pozitif ve tek sayıları listeletelim(for each döngüsüyle)

            int[] sayilar = {4,1,7,-8,23,14,51,84,-75,26,-8,-9 };

            foreach(int i in sayilar)
            {
                if(i>0 && i % 2 == 1)
                {
                   Console.WriteLine(i);
                }
            }
            //////////////////////////////////////////////////////////////

            //sıralama işlemleri dizilerde hazır komutlar var
            //short komutu diziyi küçükten büyüğe sıralıyor

            int[] values = new int[5];//5 elemanlı bir dizi

            for (int i=0; i<5; i++)
            {
                Console.Write("Sayıyı Girin: ");
                values[i] = Convert.ToInt32(Console.ReadLine());

            }

            //Array.Sort(values);//bu şekilde sıralaması için foreach döngüsü kulllanmam gerekiyor.Çünkü sayıları hafıza alıp sayıları çağırmadık.Sayıları çağırıp yazdırma işlemi yaptırmamız gerekiyor
            Array.Reverse(values);//diziyi tersten sıralıyor

            foreach(int i in values)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Dizinin uzunluğu= "+values.Length);
           
            //int values new int diyerek hafızada 5 elemanlı bir dizi oluşturdum.
            //for i=0 dan başlasın 5'e kadar benim dizimdeki bütün elemanları okusun(klavyeden aldığımız değerleri bellekte dizi için ayırdığımız 5 elemanlı yere atıyoruz)
            //array.sort diyip sayıları sıraladı sonrasında ama bu sayıları çağırıcak bişi yazmadı
            // foreach i nin sıralanmış halini yazdırdık

            Console.Read();
        }
    }
}
