using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xxx
{
    internal class Student
    {

        public void grades(string n, double g1, double g2, double g3)
        {
            Console.Clear();
            Console.WriteLine("{0} isimli öğrencinin notları: {1},{2},{3}", n, g1, g2, g3);

            double ortalama = (g1 + g2 + g3) / 3;

            Console.WriteLine(n + " isimli öğrencinin not ortalaması: " + ortalama);

            if (ortalama > 45)
            {
                Console.WriteLine("Dersi geçtiniz");
            }
            else
            {
                Console.WriteLine("Dersten kaldınız");
            }

            
        }

    }
}
