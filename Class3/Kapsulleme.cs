using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3
{
    internal class Emlak
    {
        private string semt;
        private string renk;
        private int odaSayi;
        private int katNo;
        private double alan;

        public string SEMTI
        {
            get { return semt; }
            set
            {
                semt = value.ToUpper();

            }  //kapsülleme yapmış olduk
        }

            //bir takım özellikleri kullanıcı girmiş olduktan sonra benim girmiş olduğum özelliklere göre karşıma gelsin istiyorum.
        
            public string RENGI
        {
            get { return renk; }
            set { renk = value.ToLower(); }
        }

        public int ODASAYISI
        {
            get { return odaSayi; }
            set { odaSayi = Math.Abs(value); }
        }

        public int KATNOSU
        {
            get { return katNo; }
            set { katNo = Math.Abs(value); }
        }

        public double ALANI
        {
            get { return alan; }
            set { alan = Math.Abs(value); }
        }

        
        
        }


    }

