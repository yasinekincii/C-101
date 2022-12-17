using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function5
{
    internal class Metotlar
    {
        int sum(int a,int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Metotlar mtr = new Metotlar();
            int z;
            z = mtr.sum(1,3);
            Console.Write("Toplam: "+z);

            Console.Read();
        }
    }
}
