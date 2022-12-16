using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarExample4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //baklava dilimi

            Console.WriteLine("bir sayı girin");
            int number;
            number = Convert.ToInt16(Console.ReadLine());

            for(int i=1; i<=number; i++)
            {
               for(int j=number; j>0; j--)
                {
                    if (i>=j)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    
                }
                Console.WriteLine();
            }
            
            for(int i=number-1; i > 0; i--)
            {
                for(int j=number; j>0; j--)
                {
                    if (i>=j) 
                    {
                        Console.Write("* ");                    
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
