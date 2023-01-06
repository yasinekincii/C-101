using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkingFeeQuestion
{
    internal class Class2
    {
        internal void Minibus(int saat)
        {
            double price = 6;

            if (saat>0&&saat<=1)
            {
                Console.WriteLine("Otopark Ücretiniz: "+price);
            }
            else if (saat>1)
            {
                for (int i=2; i<=saat; i++)
                {
                    price=price+(price * 21.5 / 100);                   

                }
                Console.WriteLine($"Otopark ücretiniz: {price}");
            }
            else
            {
                Console.WriteLine("Hatalı ya da eksik bir tuşlama yaptınız..");
            }
        }


        public void TicariArac(int sure)
        {
            double price = 6.5;

            if (sure>0 && sure<=1)
            {
                Console.WriteLine($"Otopark Ücreti: {price}");
            }
            else if (sure>1)
            {
                for (int i=2; i<=sure; i++)
                {
                    price = price * 1.25;
                }
            }
            else
            {
                Console.WriteLine("Hatalı ya da eksik bir tuşlama yaptınız..");
            }



        }





    }
}
