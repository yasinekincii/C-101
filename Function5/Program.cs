using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function5//namespace oluşturmuş olduğum programın ismi
{
    internal class Metotlar//class ismi başlangıçta program olarak geliyor biz de Metotlar olarak değiştirdik.
    {
        int sum(int a,int b)//static olarak tanımlanmayan bir metotla yaptık.
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            //toplayı tek başına çağırmadık çünkü erişim belirleyici kullanmadık.
            Metotlar mtr = new Metotlar();//sınıfla beraber bir nesne oluşturarak çağırmam gerekiyor.
            //mtr adında metotlar sınıfından türemiş bir nesne oluşturdum
            int z;
            z = mtr.sum(1,3);//şimdi toplayı kullanabiliyorum çünkü oluşturmuş olduğum nesne metotlar sınıfına ait ve o sınıftan türediği için
            //artık metotlar sınıfına ait alanları kullanabilirim.
            Console.Write("Toplam: "+z);

            Console.Read();
        }
    }
}
