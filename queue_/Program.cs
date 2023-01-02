using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * ilk olarak .Generic kısmını siliyorum
             * queue de ilk giren ilk çıkar (FIFO)
             */

            Queue Q1 = new Queue();

            Q1.Enqueue("Bir");//Enqueue dediğimizde içeriye objeyi eklemiş oluyoruz
            Q1.Enqueue("İki");
            Q1.Enqueue("Üç");
            Q1.Enqueue("Dört");
            Q1.Enqueue("Beş");

            //Queue den çıkartmak için bir peekimiz var
            
            object o1=Q1.Peek(); //object bir değer döner 
            //içeride herhangi bir değerin silinmesi olmadı bana preview amaçlı bir değer verdi

            object o2 = Q1.Dequeue();//bana değeri gönderdikten sonra koleksiyon içerisinden ilgili değeri silicek


        }
    }
}
