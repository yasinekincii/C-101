using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace powMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Math.Pow metodu ile ve Math.Pow metodu kullanmadan üs alma işlemlerini gerçekleştiren örnekler oluşturacağız.Pow().Parametre olarak verilen ilk sayının, yine parametre olarak verilen ikinci sayı kadar üssünü hesaplayan metottur.

            Console.Write("Sayıyı giriniz: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Üs değerini giriniz: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            double value=Math.Pow(n1,n2);
            Console.WriteLine("Math.Pow() metodu yardımıyla üs hesabı: "+value);//taban ve üs kullanıcı tarafından girilerek üs alma işlemi Math.Pow() metodu ile hesaplanmıştır.

            double result=1;
            for (int i=1; i<=n2;i++)
            {
                result = n1 * result;
            }
            Console.WriteLine("for döngüsü yardımı ile üs hesabı: "+n1);//taban ve üs kullanıcı tarafından girilerek üs alma işlemi For() döngüsü yardımıyla hesaplanmıştır.




            Console.ReadLine();
        }
    }
}
