using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace averageExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            # region  Klavyeden girilen metnin kaç kelimeden oluştuğunu bulan Console Application örneği:          

            Console.Write("Bir metin giriniz: ");
            string text = Console.ReadLine();

            string[] values = text.Split(' ');
            Console.WriteLine(values.Length);

            #endregion



        }
    }
}
