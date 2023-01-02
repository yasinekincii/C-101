using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorted_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Sorted list hashtable gibi içerisine key ve value değerleri alan bir koleksiyondur.Hashtableden farkı ise sortedlist içerisine almış olduğu her bir değerin key değerine göre A-Z'e doğru kendini sıralar
             * 
             * Key değerine göre kendini sıraladığı için ilgili key değerlerinin benzersiz(unique) olması hem de aynı veritipinde olması gerekir
             * 
             * SortedList collectionsGenericte de mevcut o yüzden generic kavramını siliyorum
             * 
             * KEY DEĞERLERİNİN VERİ TİPLERİNİN AYNI OLMASI GEREKMEKTEDİR.
             */

            SortedList sortedL = new SortedList();

            sortedL.Add(100,"Yüz");
            sortedL.Add(90,"Doksan");
            sortedL.Add(1,"Bir");
            sortedL.Add(9000,"dokuzbin");
            //sortedL.Add("A","B");


            /*
             * Hashtable ile aynı metodlara sahiptir(remove,add,find,removeat)
             * 
             */


        }
    }
}
