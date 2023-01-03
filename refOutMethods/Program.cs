using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refOutMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ref ve out anahtar sözcükleri değer tipli davranıştan referans tipli davranışa geçmenize olanak sağlar framework 7.0 versiyonu sonrasında parametrelerde ref ve out parametre değeri almaksızın rahat bir şekilde kullanılabiliyor

            int number1=2;
            DegerAta(ref number1);

        }

        static void DegerAta(ref int gelenDeger)
        {
            gelenDeger =2;
        }
    }
}
