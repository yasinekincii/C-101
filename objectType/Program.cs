using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //object
            /*
             * object tipi bütün tipleri kapsayan bir tiptir.(bütün tipleri kendi içerisinde muhafaza edebilir)
             * 
             * object{  object tipi içerisinde neleri barındırır.
             * Int,
             * Decimal,
             * string,
             * bool,
             * float,
             * double
             * class custom class
             * }
             * 
             * object   bütün tiplerin içindeki min değerden daha min değeri taşıyabilir max değerden daha max değeri taşıyabilir.
             */

            //Boxing(Kutulama)
            object o1 = 100;//object diyor ki ben bu 100 değerini saklayablirim.Ama bunu tipinde saklayabilirim diyor.object burada aslında o1 in içerisine 100 değerini int tipi olarak saklıyor.
            object o2 = 10.90;//aslında bir double değer(sonuna hiçbir şey yazmadık sonuna hiçbir şey yazmadıysak double tipiydi)
            object o3 = true;

            //object tipi kendi içerisine her türlü değeri alabiliyor bunu adı kutulama olarak geçiyor.



        }
    }
}
