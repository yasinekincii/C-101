using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carExample
{
    internal class Car
    {
        public string marka;
        public string model;
        public int modelYil;
        public double km;
        public int satisFiyati;
        public int maxindirimTutari;
        int fiyat;

        internal Car() { }

        internal Car(string _mark,string _mod)
        {
            this.marka = _mark;
            this.model = _mod;
        }

        internal Car(string _mark,string _mod,int _yil)
        {
            this.marka = _mark;
            this.model = _mod;
            this.modelYil = _yil;
        }

        public void Print()
        {
            Console.WriteLine($"Aracın markası:{marka}, modeli: {model},model yılı: {modelYil} ");
        }

        public void FiyatAta(int _teklif)
        {
            if (_teklif >= satisFiyati - maxindirimTutari)
            {
                this.fiyat = _teklif;
            }
            else
            {
                Console.WriteLine("teklifinizi arttırın..");
            }

        }
    }
}
