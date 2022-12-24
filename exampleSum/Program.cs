using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exampleSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            for (int i=1; i<=100; i++ )
            {
                total += i;
            }

            Console.WriteLine("1-100 arasındaki sayilarin toplami= {0}",total);
            Console.ReadLine();
        }
    }
}
