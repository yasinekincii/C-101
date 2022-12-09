using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sehir;
            Console.Write("Lütfen Şehir Giriniz= ");
            sehir = Console.ReadLine();

            switch (sehir) {

                case "adana": Console.WriteLine("İstanbul ilinin adana'ya uzaklığı 939km'dir");
                    break;
                case "ankara": Console.WriteLine("İstanbul ilinin ankara'ya uzaklığı 500 km'dir");
                    break;
                case "antalya": Console.WriteLine("İstanbul ilinin Antalya'ya uzaklığı 890 km'dir");
                    break;
                case "bursa": Console.WriteLine("İstanbul ilinin Bursa'ya uzaklığı 250 km'dir");
                    break;
                case "elazığ": Console.WriteLine("Elazığ ilinin İstanbul'a uzaklığı 1100 km'dir.");
                    break;
                case "izmir": Console.WriteLine("İzmir'in İstanbul'a uzaklığı 450 km'dir");
                    break;

                default: Console.WriteLine("Bu şehir hafızada mevcut değil");
                    break;

            }
            Console.ReadLine();
        }
    }
}
