﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addMonths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number>0 && number<13)
            {
                if (number == 1)
                {
                    Console.WriteLine("January");
                }
                else if (number==2)
                {
                    Console.WriteLine("February");
                }
                else if (number==3)
                {
                    Console.WriteLine("March");
                }
                else if (number==4)
                {
                    Console.WriteLine("April");
                }
                else if (number==5)
                {
                    Console.WriteLine("May");
                }
                else if (number==6)
                {
                    Console.WriteLine("June");
                }
                else if (number == 7)
                {
                    Console.WriteLine("July");
                }
                else if (number == 8)
                {
                    Console.WriteLine("August");
                }
                else if (number == 9)
                {
                    Console.WriteLine("September");
                }
                else if (number == 10)
                {
                    Console.WriteLine("October");
                }
                else if (number == 11)
                {
                    Console.WriteLine("November");
                }
                else if (number == 12)
                {
                    Console.WriteLine("December");
                }
                

            }
            else
            {
                Console.WriteLine("Geçersiz bir sayı girdiniz.");
            }

            Console.ReadLine(); 
        }
    }
}
