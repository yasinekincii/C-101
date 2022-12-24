using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examplePerimeterArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Karenin alanını ve çevresini hesaplayalım");

            int edgeSquare = 4;
            Console.WriteLine("Karenin çevresi= {0}",(edgeSquare*4));
            Console.WriteLine("Karenin Alanı= {0}",(edgeSquare*edgeSquare));

            Console.WriteLine();

            int sedge = 2, longedge = 4;
            Console.WriteLine("Dikdörtgenin alanını ve çevresini hesaplayalım");
            Console.WriteLine("Dikdörtgenin çevresi= "+(2*(sedge+longedge)));
            Console.WriteLine("dikdörtgenin alanı= "+(sedge*longedge));




            Console.Read();
        }
    }
}
