using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = {1,9,7,2,11,6,3 };

            Array.Sort(numbers);
            Array.Reverse(numbers);

            foreach (int i in numbers) 
            { 
                Console.WriteLine(" " + i);
            }
            Console.WriteLine(numbers.Length);
            

            
            
            
            
            
            
            Console.ReadLine();
        }
    }
}
