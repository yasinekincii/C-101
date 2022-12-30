using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*20 elemanlı int bir dizi oluşturalım.Değerlerimizi random sınıfının next 
             * fonksiyonu ile 1-10 arasındaki değerler ile dolduralım.Daha sonra dizi içerisindeki elemanlarımızı ekrana yazdıralım ve ilgili dizi içerisinde kaç tane 4 değeri old bulalım
             */

            int[] value = new int[20];
            Random rnd = new Random();
            int sayac = 0;

            for (int i=0; i<value.Length; i++)
            {
                value[i] = rnd.Next(1, 10);
                Console.WriteLine("Dizimizin "+ (i+1)+".değeri: "+value[i]);
                if (value[i] == 4)
                {
                    sayac++;
                }
            }
            Console.WriteLine("Dizimizin içerisinde {0} adet 4 değeri vardır.",sayac);
            Console.ReadLine();
        }
    }
}
