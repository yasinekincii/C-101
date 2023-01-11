using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    public class MusteriAdres   //Burada 2 farklı tipe sahip oldum.    1)Müşteri ve MüşteriAdres nesnesi
    {

        public string adresTip { get; set; }
        public string il { get; set; }
        public string ilce { get; set; }
        public string adres { get; set; }


        public MusteriAdres()//kendi özel tiplerinizin yapıcı metotları innertype olsa da çalışır.
        {
            Console.WriteLine("Müşteri adresi yapıcı metotu çalıştı.");
        }

        public void MusteriAdresTestMetot()
        {
            Console.WriteLine("MusteriAdresTestMetot");
        }
    }
}
