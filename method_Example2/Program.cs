﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ogrenciAd = string.Empty;
            string ogrenciSoyad = string.Empty;
            decimal not1 = 0;
            decimal not2 = 0;
            decimal not3 = 0;
            

            Console.WriteLine("Merhaba Ortalamasını hesaplamak istediğiniz öğrencinin bilgilerini giriniz");

            Console.Write("Ad :");
            ogrenciAd = Console.ReadLine();

            Console.Write("Soyad :");
            ogrenciSoyad = Console.ReadLine();

            Console.Write("Not 1:");
            not1 = decimal.Parse(Console.ReadLine());

            Console.Write("Not 2:");
            not2 = decimal.Parse(Console.ReadLine());

            Console.Write("Not 3:");
            not3 = decimal.Parse(Console.ReadLine());

            Student O = new Student();
            O.ogrenciNotHesapla(ogrenciAd, ogrenciSoyad, not1, not2,not3);

            Console.ReadLine();
        }
    }
}
