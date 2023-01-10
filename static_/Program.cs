using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //static: nesne örneği alınmadan ulaşabildiğimiz metot, field, sınıf..
            //Tip M1=new Tip();
            //Tip

            //stack bölge içerisinde pointer ımız oluştu..
            Student O1;
            //stack bölgede pointer oluştuğu zaman static olan bir yapıcı metot çalıştı ve yine class içerisinde tanımlı olan static field,metot static dediğimiz bölgede oluşturuldu.
            Student.Test2();

            O1 = new Student();
            //stack bölgede pointer=>Kendisini heap bölgede tamamladı..static olmayan tanımlarını tamamladı
            O1.Test1();//nesne örneği alındıktan sonra test1 adındaki metoduma ulaşabildim.
            
        }
    }
}
