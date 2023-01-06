using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreachExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Örnek 1: Liste içindeki elemanlar yazdırma

            string[] members = {"ayşe","fatma","hayriye","mesut","ali" };
            foreach (var element in members)
            {
                Console.WriteLine(element+", ");
            }

            Console.Clear();
            //Örnek 2: C# ta 10 elemanlı dizi içine kulanıcının 10tane şehir eklemesini sağlayan  Girilen baş harfe göre şehirleri listeleyen program

            string[] citys = new string[10];    //10 elemanlı bir dizi oluşturdum.
            string town;

            Console.WriteLine("Listemizin elemanlarını girelim \n=========================");
            for (int i=0; i<citys.Length; i++)
            {
                Console.Write("Listemizin "+(i+1)+". elemanını giriniz: ");    //kullanıcıdan şehirleri girmesini istedik
                town = Console.ReadLine();                                      //kullanıcının girdiği şehirleri Listemize ekledik.
                citys[i] = town;
            }

            Console.Write("\nListelemek istediğiniz şehirin,şehirlerin baş harfini giriniz: ");       //kullanıcıdan baş harf istedik
            char letter = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("\nGirilen kullanıcı adına göre Şehirleri Listeleyelim\n=========================");
            foreach (var element in citys)
            {
                if (element[0]==letter)
                {
                    Console.WriteLine(element);     //Listemizin ilk harfi kullanıcıdan alınan harf ile aynıysa o şehiri yazdır.
                }
            }


            Console.Clear();
            //Örnek 3: Diziye rastgele atanan sayıların ortalamasını yazdırma

            ArrayList values = new ArrayList();                 //Dizi oluşturdum.

            Random rnd = new Random();                          //Random değer atayabilmek için Random sınıfımı oluşturdum.
            

            for (int i=0; i<10; i++)
            {
                values.Add(rnd.Next(100));                      //Dizime random değerler atadım.
            }

            decimal d1=0;
            int count = 0;
            foreach (var element in values)
            {
                d1+= (int)element;                              //atadığım random değerlerini topladım.
                count++;
            }
            Console.WriteLine("Girilen sayıların ortalaması: "+(d1/count));



            //Örnek 4: C# String Dizi İçindeki En Uzun Kelimeyi Bulma

            string[] str = { "yas", "ekin", "fenerbahce", "kadıköy", "izmit" };

            string longest = "";
            int count1 = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length > count)
                {
                    count1 = str[i].Length;
                    longest = str[i];
                }
            }
            Console.WriteLine("Dizimizin en uzun kelimesi: " + longest);
        }
    }
}
