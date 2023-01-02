using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * İlk önce Collections.Generic in Generic kısmını kaldırıyoruz
             * 
             * Bu koleksiyonumuzun temel prensibi içerisine almış olduğu dataları bir komut kullanarak sıralı bir şekilde kendi listesinden çıkartmamıza olanak sağlıyor
             * 
             * LIFO(Last in First Out)son giren ilk önce çıkıyor.
             *              
             */

            Stack S1 = new Stack();

            S1.Push("Bir");//push metoduyla içeriye datalarımızı eklemeye başlıyoruz
            S1.Push("İki");
            S1.Push("Üç");
            S1.Push("Dört");
            S1.Push("Beş");

            //bunlar geriye object olarak içerisinde tuttukları değerleri dönerler

            object o1 = S1.Pop();//popta ilgili datayı bana gönderdi.Listeden çıkarttı(remove etti)
            object o2 = S1.Peek();//peekte ise datayı bana göndericek ama koleksiyondan çıkartmayacak önizleme yapıcak benim için
            //üçü bana gönderdi ama üçü koleksiyondan çıkartmadı



        }
    }
}
