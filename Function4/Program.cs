using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function4
{
    internal class Program
    {
        private static int CalculateCube(int number)
        {
            int result = number * number * number;
            return result;
        }

        static void Main(string[] args)
        {
            //klavyeden girilen sayının küpünü hesaplat

            Console.WriteLine("Küp değerinin hesaplanmasını istediğiniz sayıyı giriniz: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CalculateCube(x));

            Console.ReadLine();
        }
    }
}
