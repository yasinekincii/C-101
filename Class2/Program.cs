using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student ysn = new Student();//öğrenci sınıfından ysn isminde bir nesne ürettim

            ysn.ADI = "Yasin";
            ysn.SOYADI = "Ekinci";
            ysn.ALANI = "Türkçe-Matematik";
            ysn.YASI = 16;

            Console.WriteLine("Ad= {0}, Soyad= {1}, Alanı= {2}, Yaşı= {3}", ysn.ADI, ysn.SOYADI, ysn.ALANI, ysn.YASI);

            Console.ReadLine();

        }
    }
}
