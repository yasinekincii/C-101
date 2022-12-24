using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOut
{
    internal class Program
    {

        static void arttir(ref int s)
        {
            s++;
        }

        static void Main(string[] args)
        {
            //refout referans türleriyle ilgili bir kavramdır

            int a = 8;
            arttir(ref a);
            Console.WriteLine(a);//normal şartlarda 9 olması gerekir a değerinin
        }
    }
}
