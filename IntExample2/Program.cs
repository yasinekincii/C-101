using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c,d; 
            a = 8;b = 10;
            c = a * b;
            Console.WriteLine("a*b:"+c);
            Console.WriteLine("a*b:{0}",c);

            d = (a + b) / 2;
            Console.WriteLine("Bölüm değeri:{0}",d);

            Console.Read();
        }
    }
}
