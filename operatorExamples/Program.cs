using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İsminizi giriniz: ");
            string name = Console.ReadLine();
                       
            
            Console.WriteLine("doğum yılınızı giriniz: ");
            int yil = Convert.ToInt16(Console.ReadLine());

            Console.Clear();

            int year = DateTime.Now.Year;

            Console.WriteLine("İsminiz "+name+" Yaşınız "+(year-yil));

            Console.ReadLine();

        }
    }
}
