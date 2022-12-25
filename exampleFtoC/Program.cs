using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exampleFtoC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //F türünden girilen sıcaklığı C türüne çeviren uygulama

            Console.WriteLine("Sıcaklığı giriniz= ");

            double temperature = Convert.ToDouble(Console.ReadLine());
            double result;

            result = (temperature - 32) * 5 / 9;
            Console.WriteLine("Girilen F derecesinin C karşılığı= " + result);



            Console.ReadLine();
        }
    }
}
