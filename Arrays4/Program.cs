using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //foreach= Bir dizideki elemanların herbiri için
            //for each= biri dizi veya nesnenin tüm elemanlarına ulaşmak için kullanılır.
            //for each dizinin herbir elemanı için döngü içindeki işlemi gerçekleştiriyor.

            string[] citys = { "Mersin", "İzmir", "Kocaeli", "Artvin", "Ankara", "Erzurum", "ŞanlıUrfa" };
            foreach (string x in citys)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("*************");

            int[] numbers = { 15, 26, 59, 8, 65, 78, 12, 65 };
            foreach (int y in numbers)
            {

                Console.WriteLine(y);
            }

            Console.WriteLine("********");
            int sum = 0;
            int[] values = { 7, 45, 25, 43 };

            foreach (int k in values)
            {
                sum = sum + k;
            }
            Console.WriteLine("Toplam değeri= " + sum);

            Console.WriteLine("****");
            //bir tane dizi oluşturalım sadece ikiye tam bölünen elemanları alalım.

            int[] rakamlar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (int i in rakamlar) {

                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }            

            }
            Console.WriteLine("*********");
            
            
            //Dizinin faktöriyelini almak istiyoruz







            Console.Read();
        }
    }
}
