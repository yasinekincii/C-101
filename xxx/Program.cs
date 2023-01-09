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
            //Maaşı ve zam oranı girilen işçinin zamlı maaşını hesaplayarak ekranda gösteren 

            double maas = 10.450;
            double zam = 35;

           double  zamlıMaas = maas+(maas*zam/100);
           Console.WriteLine($"İşçinin zamlı maaşı: {zamlıMaas}");

        }
    }
}
