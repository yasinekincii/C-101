using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarExample3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Kenar Sayısını Giriniz: ");
            int edge;
            edge = Convert.ToInt16(Console.ReadLine());

            //üst kenar
            for(int i=1; i<=edge; i++)
            {
                Console.Write("* ");
            }

            Console.WriteLine();
            //sol kenar
            for (int i=1;i<=edge-2;i++)
            {
                Console.Write("*");

                //aradaki boşluklar
                for(int j=1; j<=edge-2; j++)
                {
                    Console.Write("  ");
                }

                //sağ kenar
                Console.Write(" *");
                Console.WriteLine();
            }

            //alt kenar
            for(int n=0; n<edge; n++)
            {
                Console.Write("* ");
            }

            Console.ReadLine();
        }
    }
}
