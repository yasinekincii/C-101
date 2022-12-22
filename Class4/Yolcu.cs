using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class4
{
    internal class Yolcu
    {
        private string ad;
        private string soyad;
        private int yas;
        private string cinsiyet;

        public string ADI
        {
            get { return ad; }
            set//ilk harfi büyük olsun sadece
            {
                //ad[0].ToString().ToUpper() + ad.Substring(1) = value;
                ad = value[0].ToString().ToUpper() + value.Substring(1).ToLower();

            }

        }

        public string SOYADI
        {
            get { return soyad; }
            set { soyad = value[0].ToString().ToUpper() + value.Substring(1).ToLower(); }
        }

        public int YASI
        {
            get { return yas; }
            set { yas = Math.Abs(value); }
        }

        public string CINSIYET
        {
            get { return cinsiyet; }
            set { cinsiyet = value.ToLower(); }
        }



     }



}

