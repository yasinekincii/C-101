using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace localFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //.net flamework 4.7 sonrası çalışır.
            //Local Functions: metotlarımızın içerisinde metotlar tanımlayabiliyoruz.Sadece o metodun ulaşabildiği metotlar tanımlayabiliyoruz.

            localFunctionKullanimi(12, 22);
            

        } 

        static void localFunctionKullanimi(int sayi1,int sayi2)
        {
            
            int topla(int gelensayi1,int gelensayi2) //bu topla metodum localfunctionkullanım scope ları arasında çağırılabilir
            {
                return gelensayi1 + gelensayi2; 
            }

            int toplamDeger = topla(sayi1,sayi2);
            Console.WriteLine(toplamDeger);
        }
    }
}
