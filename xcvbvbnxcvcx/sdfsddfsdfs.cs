using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xcvbvbnxcvcx
{
    internal class Kutu
    {
        private double uzunluk;
        double genislik;
        double yukseklik;

         public Kutu()
        {
            Console.WriteLine("Constructor metot çalıştı.");
        }

        public Kutu(double uzunluk,double genislik,double yukseklik)
        {
            this.uzunluk = uzunluk;
            this.genislik = genislik;
            this.yukseklik = yukseklik;

        }

        ~Kutu()
        {
            Console.WriteLine("Sınıf Yıkılıyor..");
            Console.ReadLine();
        }


        public double GetUzunluk()
        {
            return uzunluk;
        }


        public void SetUzunluk(double uzunluk)
        {
            if (uzunluk >= 2)
            {
                this.uzunluk = uzunluk;
            }
            else
            {
                this.uzunluk = 2;
            }

        }


        public double Genislik
        {
            get { return this.genislik; }
            set
            {
                if (value >= 2)
                {
                    this.genislik = value;
                }
                else
                {
                    this.genislik = 2;
                }
            }
        }


        public double Yukseklik { get; set; }


        public string GetAccount(int UserID)
        {
            string result = string.Empty;
            if (UserID > 0)
            {
                result = "yasin";
                return result;
            }
            else
            {
                throw new Exception("Hata!");
            }
        }

    }
}
