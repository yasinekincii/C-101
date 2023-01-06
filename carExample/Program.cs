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
            Car C1 = new Car("merc","c");          

            
            C1.BilgileriGoruntule();

            
            C1.alisFiyati = 30;
            C1.satisFiyati = 210;
            C1.maxIndirimTutari = 10;
            C1.FiyatAta(150);




            Console.ReadLine();
        }
    }
}
