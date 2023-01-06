using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Klavyeden girilen bir cümledeki kelime sayısını bulunuz.
            
            Console.WriteLine("Bir cümle girin: ");
            string text = Console.ReadLine();               //kullanıcıdan alınan değer text değişkenine atandı.
            int numberOfWords = 0;

            string[] words = text.Split(' ');               //kullanıcının girdiği metini boşluklar arasından ayırdı.            
            

            Console.WriteLine($"\nGirilen metindeki kelime sayısı: {words.Length}");       //sayacım dizimdeki eleman sayısını göstericek.
            #endregion


            #region 
            






            #endregion
        }
    }
}
