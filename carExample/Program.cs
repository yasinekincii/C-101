using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car C1 = new Car();

            C1.marka = "mercedes";
            C1.model = "E";
            C1.modelYil = 2022;
            C1.km = 41.138;
            C1.satisFiyati = 600;
            C1.maxindirimTutari = 10;

            C1.FiyatAta(590);

          

            Console.ReadLine();
        }
    }
}
