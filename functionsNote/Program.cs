using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionsNote
{
    internal class Program
    {
        private static int cube(int number)
        {
            return number * number * number;
        }


        static void Main(string[] args)
        {
            Console.Write("Kübünün hesaplanmasını istediğinizi sayıyı giriniz: ");
            int n1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Girilen sayının kübü= "+cube(n1));

            Console.Read();

        }
    }
}
