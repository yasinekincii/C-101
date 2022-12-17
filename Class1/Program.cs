using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car Object = new Car();//nesne yardımı ile çağırdık.

            Object.price = 150000;
            Object.gear = "dsg";
            Object.model = "2021";
            Object.licensePlate = "34 C 78";
            Object.colour = "black";


            Console.WriteLine("Arabanın Fiyatı: "+Object.price);


            Console.ReadLine();


        }
    }
}
