using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMethod2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random number = new Random();
            int s1;
            s1 = number.Next();
            Console.WriteLine(s1);

            Console.Read();
        }
    }
}
