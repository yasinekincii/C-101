using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorexample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan gelen 3 farklı sınav notunun  ortalaması 45 değerine eşit veya
             * büyük mü olarak kontrol edelim
             */

            Console.WriteLine("Sınav notlarınızı giriniz: ");
            double exam1 = Convert.ToDouble(Console.ReadLine());
            double exam2 = Convert.ToDouble(Console.ReadLine());
            double exam3 = Convert.ToDouble(Console.ReadLine());

            double result = (exam1 + exam2 + exam3) / 3;
            bool result2 = result >= 45;
            Console.WriteLine("Ortalama: "+result);
            Console.WriteLine(result2);

            Console.ReadLine();
        }
    }
}
