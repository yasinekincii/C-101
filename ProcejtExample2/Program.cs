using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcejtExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            

            //değişken:girdiğiniz verilerin ya da alanların bellekte tutulma şekli

            String name;
            name = "yasin";
            Console.WriteLine(name);

            String city;
            city = "İstanbul";
            Console.WriteLine(city);

            String secondName;
            Console.Write("İsminizi giriniz: ");
            secondName = Console.ReadLine();
            Console.WriteLine("Hoşgeldiniz: "+secondName);
             




            Console.ReadLine();
        }
    }
}
