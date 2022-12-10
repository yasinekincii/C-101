using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //diziler nedir? Sıralı listelerdir
            //bir komutun, bir kot satırının dizi olduğunu programa anlatmak için köşeli parantez kullanılır.
            //indeks dizinin bellekte kaçıncı sırada tutulduğunu gösterir ve dizilerde indeks değeri sıfırdan başlar
            //dizi tanımlaması değişkenin türü köşeli parantez dizinin ismi=

            int[] numbers = {10, 45, 21, 35, 64, 75, 84, 26 };
            Console.WriteLine(numbers[0]);


            string[] names = {"ali","mehmet","veli","emel","baran"};
            Console.WriteLine(names[0]);

            //3 tane şehir girelim daha sonra bu 3 şehiri listeletelim yani önce yukarıda bir dizi oluşturalım aşağıdaki komutlarla da o dizinin elemanlarını listeletelim
            //bu örnekte bütün elemanlarını listeleticeğiz
            //dizi oluştururken eğer dizinin değerleri klavyeden girilicekse önceden bellekte alan atamsı yapılıyor mesela ben 5 elemanlık bir dizi kullanıcam

            string[] sehirler = new string[3];

            for(int i=0; i<3; i++)
            {
                Console.Write("Şehir: ");
                sehirler[i] = Console.ReadLine();
            }

            Console.WriteLine("*** Şehirler Listesi***");

            for(int i=0; i<3; i++)
            {
                Console.WriteLine(sehirler[i]);
            }
             
            Console.Read();
        }
    }
}
