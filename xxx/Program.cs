using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen bir cümledeki kelime sayısını bulunuz.

            Console.WriteLine("Bir cümle girin: ");
            string text = Console.ReadLine();               //kullanıcıdan alınan değer text değişkenine atandı.
            int numberOfWords = 0;                          

            string[] words = text.Split(' ');               //kullanıcının girdiği metini boşluklar arasından ayırdı.

            foreach (var word in words)
            {
                numberOfWords++;                            //her bir elemanda sayacımı bir arttırıyorum.
            }
            Console.WriteLine($"\nGirilen metindeki kelime sayısı: {numberOfWords}");       //sayacım dizimdeki eleman sayısını göstericek.





            Console.ReadLine();
        }
    }
}
