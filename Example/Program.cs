using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Qasqai car = new Qasqai();
            car.marka = "nissan";
            car.hasarKaydi = 1500;
            car.rengi = "Beyaz";
            car.yili = 2015;
            car.nerede = "istanbul";

            Console.WriteLine("Marka="+car.marka);
            Console.WriteLine("Hasar kaydı"+car.hasarKaydi);
            Console.WriteLine("Rengi "+car.rengi);
            Console.WriteLine("Üretim yılı "+car.yili);
            Console.WriteLine("Nerede"+car.nerede);
            Console.WriteLine("\n");

            car.marka = "renault";
            car.hasarKaydi = 10000;
            car.rengi = "gri";
            car.yili = 2008;
            car.nerede = "İstanbul";

            Console.WriteLine(car.marka);
            Console.WriteLine(car.hasarKaydi);
            Console.WriteLine(car.rengi);
            Console.WriteLine(car.yili);
            Console.WriteLine(car.nerede);

            Console.ReadLine();

           
        }
    }
}
