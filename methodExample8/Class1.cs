using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodExample8
{
    internal class Class1
    {

       public void DizininElemanlarınıGir(params int[] n)
        {
            for (int i=0; i<n.Length; i++)
            {             

                Console.WriteLine(i+1 + ". elemanı giriniz");
                n[i]=Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            Console.WriteLine("Dizinin elemanları:  ");
            for(int i =0; i < n.Length; i++)
            {
                Console.WriteLine(n[i]);
            }
        }

        public void EnBuyukSayi(params int[] enBuyuk)
        {
            int enBuyukDeger=enBuyuk[0];

            foreach(var element in enBuyuk)
            {
                if (element > enBuyukDeger)
                {
                    enBuyukDeger = element;
                }
            }

            Console.WriteLine("Girilen dizinin en büyük elemanı: "+enBuyukDeger);
        }


        public void EnKucukSayi(params int[] enKucuk)
        {
            int enKucukDeger = enKucuk[0];

            for (int i=0; i<enKucuk.Length;i++)
            {
                if (enKucuk[i] < enKucukDeger)
                {
                    enKucukDeger = enKucuk[i];
                }
            }

            Console.WriteLine("Girilen dizinin en küçük elemanı: "+enKucukDeger);
        }







    }
}
