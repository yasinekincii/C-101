using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionNote2
{
    internal class Program
    {

      int fark(int s1,int s2)
        {
            return s1 - s2;
        }

        static void Main(string[] args)
        {
            Program mtr = new Program();
            int x=mtr.fark(5,3);
            Console.WriteLine("Fark = "+x);

            Console.ReadLine();
        }
    }
}
