using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExample4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String ad;
            Console.WriteLine("Lütfen isminizi giriniz: ");
            ad = Console.ReadLine();//ad benim enter'a basıp klavyeden okutacağım değer
            Console.WriteLine("Merhaba: {0}",ad);
            //burda 0 nolu indisim benim ada karşılık gelen değerim
            //programlamada sayma değerleri diziler,parametreler için 0'dan başlar.
            Console.Read();//bunu okusun
        }
    }
}
