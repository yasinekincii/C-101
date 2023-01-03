using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student S = new Student();

            Console.WriteLine("Öğrencinin adını soyadını girin:");
            string name = Console.ReadLine();

            Console.Write("Öğrencinin 1.sınav notunu giriniz: ");
            double grade1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Öğrencinin 1.sınav notunu giriniz: ");
            double grade2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Öğrencinin 1.sınav notunu giriniz: ");
            double grade3 = Convert.ToDouble(Console.ReadLine());

            S.grades(name, grade1, grade2, grade3);




            Console.ReadLine();
        }
    }
}
