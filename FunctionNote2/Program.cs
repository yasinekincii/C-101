using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionNote2
{
    internal class Program
    {

        private static void print(string info)
        {

            for (int i=0; i<3; i++)
            {
                Console.WriteLine(info);
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Yazdırmak istediğiniz metni giriniz: ");
            string x = Console.ReadLine();
            print(x);



            Console.ReadLine();
        }
    }
}
