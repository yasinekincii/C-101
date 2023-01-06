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
        public int modelYili;
        public decimal km;
        public int yakitTipi;
        public int vitesTipi;
        public decimal alisFiyati;
        public decimal satisFiyati;
        public decimal maxIndirimTutari;
        public decimal fiyat;

        public Car()
        {

        }

        internal Car(string _marka,string _model)
        {
            marka = _marka;
            model = _model;
        }

        internal Car(string _marka,string _model,int _modelYil)
        {
            marka = _marka;
            model = _model;
            modelYili = _modelYil;
        }


        internal Car(string _marka,string _model,int _modelYili,decimal _km)
        {
            marka = _marka;
            model = _model;
            modelYili = _modelYili;
            this.km = _km;

        }

        internal void BilgileriGoruntule()
        {
            Console.WriteLine("Arabanın markası {0}, modeli: {1}, model yili: {2}, km: {3}, yakit tipi: {4}, vites tipi: {5}, alış fiyatı: {6}, satış fiyatı: {7}, max indirim tutarı: {8}, fiyat:{9}",marka,model,modelYili,km,yakitTipi,vitesTipi,alisFiyati,satisFiyati,maxIndirimTutari,fiyat);
        }

        public void FiyatAta(decimal _fiyat)
        {            
            if (_fiyat<satisFiyati-maxIndirimTutari)
            {
                Console.WriteLine("\nKurtarmıyor.");
            }
            else
            {
                this.fiyat = _fiyat;
                Console.WriteLine("\nAraç {0} fiyatına satılmıştır.",fiyat);
            }

        }

       



    }
}
