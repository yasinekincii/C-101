using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashTableExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Hashtable içerisine ENG-TR olarak data eklemeniz
             * 
             * Yeni Kayıt eklemek istiyor musunuz E/H
             * E:Yeni kayıt ekleme işlemi devam etsin
             * H:Tüm listeyi yazdırın
             * 
             * var olan bir key değeri ekleniyor ise kullanıcıya bu değer daha önceden ...şeklinde sistemimizde bulunmaktadır.
             *              
             */


            Hashtable H1 = new Hashtable();
            string deger;


            do
            {
                Console.Write("Sözlüğünüze ekleme yapmak istiyor musunuz?\nEklemek için E\nDurmak ve değerleri yazdırmak için H değerini tuşlayınız.\n");
                deger = Console.ReadLine();
                deger=deger.ToLower();
                Console.Clear();


                if (deger == "e")
                {
                    Console.WriteLine("sözlüğe eklemek istediğiniz ingilizce ve türkçe değerleri girin");

                    Console.Write("İngilizcesini girin: ");
                    string eng = Console.ReadLine();

                    Console.Write("Türkçesini giriniz: ");
                    string tr = Console.ReadLine();

                    if (H1.ContainsKey(eng))
                    {
                        Console.WriteLine("Girilen {0} değeri sözlükte bulunmaktadır.", eng);
                    }
                    else
                    {
                        H1.Add(eng, tr);
                    }
                }
                else if (deger == "h")
                {
                    Console.WriteLine("Sözlük: ");
                    foreach (DictionaryEntry element in H1)
                    {
                        Console.WriteLine("ENG: {0}, TR: {1}",element.Key,element.Value);
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı ya da eksik bir tuşlama yaptınız tekrar deneyiniz..");
                }


            } while (deger == "e");


            Console.ReadLine();
        }
    }
}
