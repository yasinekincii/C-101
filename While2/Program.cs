using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faktöriyel yap
            int result = 1;
            int i = 1;
            int number;
            Console.Write("Faktöriyelinin hesaplanmasını istediğiniz sayıyı giriniz=");
            number = Convert.ToInt32(Console.ReadLine());
            
            while (number>0 && i<=number) 
            {
                result = i * result;
                i++;
            }
            Console.WriteLine("Girilen Sayının Faktöriyeli= {0}",result);


            //diğer yöntem

            int value;
            Console.Write("Fakt hesaplanmasını istediğiniz sayıyı giriniz");
            value = Convert.ToInt32(Console.ReadLine());
            result = 1;

            while (value>1) 
            {
                result = value * result;
                value--;
            }
            Console.WriteLine("Sonuç ="+result);


            Console.ReadLine();
        }
    }
}
