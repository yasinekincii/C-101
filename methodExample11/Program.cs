using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodExample11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bu örneğimizde C# ile Bubble Sort Sıralama algoritması oluşturacağız

            Console.Write("Dizimizin eleman sayısı: ");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------------\n");

            int[] ints = new int[arraySize];


            
            Console.WriteLine("Dizinin elemanlarını giriniz:    \n-------------------------");
            for (int i=0; i<arraySize;i++)
            {
                Console.Write(i+1 +".eleman :");
                ints[i] = Convert.ToInt32(Console.ReadLine());              

            }
            Console.Write("\n");
            DizininElemanlari(ints);
            Console.Write("\n");





            int gecici = 0;
            for (int i=arraySize-1; i>=0;i--)
            {
                for (int j=0,k=j+1;k<=i;j++,k++)
                {
                    if (ints[j] > ints[k])
                    {
                        gecici = ints[j];
                        ints[j] = ints[k];
                        ints[k] = gecici;
                    }
                    DizininElemanlari(ints);
                }

            }
            Console.ReadLine();
        }

        static public void DizininElemanlari(params int[] intt)
        {
            Console.Write("Dizinin Elemanları:\t");
            for (int i=0;i<intt.Length;i++)
            {
                Console.Write(intt[i]+" ");
                
            }
            Console.WriteLine();

        }


    }
}
