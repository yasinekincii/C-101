using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exampleMultiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 5, n2 = 8,total=0;

            for (int i=1; i<=n2; i++)
            {
               total += n1;
            }

            Console.Write("Çarpım işlemi kullanmadan yapılan işlemin sonucu= "+total);

            Console.Read();
        }
    }
}
