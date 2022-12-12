using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            decimal x = 0.994M;//sonuna m harfini ekledik.
            decimal y = 999999;

            Console.WriteLine("Para 1 {0:C}",x);
            Console.WriteLine("Para 2 {0:C}",y);

            x = 0.996M;
            Console.WriteLine("Para 1{0:C}",x);

            Console.WriteLine("X: "+x);
            Console.WriteLine("Y: "+y);



            Console.ReadLine();
        }
    }
}
