using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarExampl2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kenar Sayısını Giriniz");
            int edge;
            edge = Convert.ToInt16(Console.ReadLine());

            for(int i=1; i <=edge; i++)
            {
                for(int j=1; j<(edge*2); j++)
                {
                    if(i==1 || i == edge)
                    {
                        if (j % 2 == 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        if(j==1 || j == edge * 2 - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine(" ");
            }            
            
            
            Console.ReadLine();
        }
    }
}
