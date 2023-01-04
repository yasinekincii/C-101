using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodExample8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C# Console uygulamasında oluşturulmuş bir dizi içindeki en büyük ve en küçük sayıyı metotları kullanarak bul
            Class1 C1 = new Class1();            

            int[] ints = new int[5];
            C1.DizininElemanlarınıGir(ints);
            C1.EnBuyukSayi(ints);
            C1.EnKucukSayi(ints);

            Console.ReadLine();

            
        }

        
    }
}
