using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

//bunlar bizim uygulamalar içerisinde kullanacağımız kütüphanelerin tanımıdır.
//mainde de ilgili nesneyi kullanabilirsin

namespace array_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //arrayList .net'in kütüphanelerinde bulunan bir sınıfımız
            //using System.Collections;

            int capacity = 0;//Capacity=Koleksiyonumuzun alabileceği max değeri ifade eder.(4 4 artıyor)
            int Count = 0;//koleksiyonun içerisindeki mevcut var olan değer sayısını ifade eder.

            ArrayList A1 = new ArrayList();
            //kütüphanelere bakarsan system.Collectionsın siyah renkte old görebilirsin
            //bunun sebebi biz burada arrayList kullandığımız ve array list system collections kütüphanesinde bulund için

            //yukarıdaki kütüphaneler yazılımcıya kolaylık olsun diye flamework versiyonuna göre default gelir(hepsi değil)

            #region Tek Değer EKleme
            A1.Add("yasin EKİNCİ");

            capacity = A1.Capacity;
            Count = A1.Count;

            //a1. dedikten sonra add metodumuz var.Add metodu array listimizin içerisine sadece 1 değer eklememize yarar.
            //object veri tipinden değer aldığı için eklemiş old bu değerler herhangi bir değer olabilir.
            A1.Add(100);
            #endregion

            #region Birden fazla değer ekleme işlemi
            ArrayList A2 = new ArrayList();
            A2.Add("can");
            A2.Add("Bozkır");
            A2.Add("Atilla");            

            A1.AddRange(A2);

            //A1 koleksiyonunun içerisine A2 koleksiyonu içerisinde olan değerleri aldı
            #endregion

            #region Capacity & Count inceleme
            capacity = A2.Capacity;
            Count = A2.Count;
            #endregion

            #region Koleksiyon içerisindeki değere ulaşmak

            if (A1.Contains("Can"))
            {
                int indexDegeri = A1.IndexOf("can");//içeride vermiş olduğumuz değerin bize o koleksiyondaki indeks karşılığını veriyor
                A1.RemoveAt(indexDegeri);
            }

            object o1 = A1[3];
            string s1 = A1[3].ToString();
            int i1 = (int)A1[1];

            A1[3] = "Hamza Atilla";

            object[] D1 = A1.ToArray();//arraylistemizin içerisinde bulunan tüm dataları bize dizi olarak verir

            A1.Clear(); //clear bütün değerleri silicek ama capacity aynı kalıcak
            A1.TrimToSize();//ilgili koleksiyonun sizeını yeniden boyutlandır(değer aldıktan sonraki ilk haline geri döndürdü)
            //clear metodundan sonra yüksek kalan capacityi ilk hali olan 4'e çekiyor.(Ram için)

            #endregion

            #region Koleksiyonlar yardımcı Komutlar

            bool kontrol1 = A1.Contains("Atilla");//contains metodu parametre olarak istemiş old değeri koleksiyon içerisinde olup olmadığına bakar
            bool kontrol2 = A1.Contains(900);

            #endregion

            #region ArrayList sıralama

            //Dizinin mevcut elemanlarını ters olarak sıralama
            A1.Reverse();//ilgili koleksiyon tam tersi şekilde yazılacak

            //A-Z Sıralama
            A1.Sort();//dizinin içerisinde bulunan değerleri a'dan z'ye doğru sıralıyor

            #endregion

            #region ArrayList koleksiyonu içerisindeki değeri silme

            A1.Remove("Hamza Atilla");//A1'in içerisinde hamza adında bir değer yok indeksi komple kaldırdı altındaki değer bir üste kayıcak
            A1.RemoveRange(1, 2);//bana A1 array listin içinde bulunan bir başlangıç indeksi ver
                                 //1. indeksten başla silmeye
                                 //kaç eleman sileyim?
                                 //2 eleman sil
            A1.RemoveAt(0);//remove at bir indeks alır ilgili indeksteki değeri kaybeder

            #endregion





        }
    }
}
