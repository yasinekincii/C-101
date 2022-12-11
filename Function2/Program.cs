using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function2
{
    internal class Program
    {
        private static void yazdir(string bilgi)//yazdir adlı metodumun içine bir değişken oluşturduk.(string bilgi adında bir değişken oluşturduk)(bunu birazdan aşağıda kullanıcaz)
        { 
            //burada yazdır adlı komutumun ne iş yapıcağını yazıcam

            for(int i=0; i<10; i++)
            {
                Console.WriteLine(bilgi);//string türünden tanımladığım bu bilgiyi bana yazdırsın.
                //bilgiyi aşağıda çağırıcam
            }
        }

        static void Main(string[] args)
        {
            //klavyeden ekrana bir mesaj girin o mesajı bize 10 kere yazdır.

            Console.Write("Metni Girin: ");
            string blg = Console.ReadLine(); //bu değişken kullanıcının klavyeden girmiş olduğu değişkeni tutucak
            yazdir(blg);


            Console.Read();
        }
    }
}
