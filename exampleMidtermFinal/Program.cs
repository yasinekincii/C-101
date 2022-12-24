using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exampleMidtermFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Vize notunuzu giriniz= ");
            int midterm = Convert.ToInt32(Console.ReadLine());

            Console.Write("Final notunuzu giriniz= ");
            int final = Convert.ToInt16(Console.ReadLine());

            if (midterm<0 || midterm>100 || final<0 || final>100)
            {
                Console.WriteLine("Hatalı bir giriş yaptınız tekrar deneyiniz");
            }
            else
            {
                Console.WriteLine("Ortalama= "+((midterm*0.4)+(final*0.6)));
            }


            Console.ReadLine();
        }
    }
}
