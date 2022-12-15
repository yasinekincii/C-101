using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace short_ushort
{
    internal class Program
    {
        static void Main(string[] args)
        {

            short a; // -32,768 , +32,767 arasında değer alır.(int16'nın karşılığı)
            ushort b; // 0  , 65.535 arasında

            short n1, n2, n3;
            n1 = 32767;
            n2 = -32768;
            n3 = 40;

            Console.Write(n1+n2+n3);


            ushort n4, n5;
            n4 = 0;
            n5 = 65535;
            Console.WriteLine(n4+n5);

            Console.ReadLine();            
        }
    }
}
