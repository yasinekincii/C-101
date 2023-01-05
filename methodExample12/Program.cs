using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodExample12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C ile yarıçapı kullanıcı tarafından girilen bir dairenin alanını ve çevresini metot kullanarak hesapla

            Console.Write("Alan ve çevresinin hesaplanmasını istediğiniz dairenin yarıçapını giriniz: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("=========================\n");

            Console.WriteLine("Dairenin Alanı: "+AreaOfCircle(r)+"\n=========================");
            Console.WriteLine("Dairenin Çevresi: "+Perimeter(r)+ "\n=========================");

            Console.ReadLine();                
        }

        static public double AreaOfCircle(double db)
        {
            double result = Math.PI * db * db;
            return result;
        }


        static public double Perimeter(double db)
        {
            double result = Math.PI * 2 * db;
            return result;

        }


    }
}
