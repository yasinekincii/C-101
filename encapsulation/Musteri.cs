using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
    internal class Musteri
    {
        //internal: encapsulation namespacei içerisinde nerede çağırılırsa çağırılsın public gibi algıla demektir.


        public Musteri()//ctor yazıp tab tuşuna 2 kere basarsan yapıcı metodumuzu oluşturursun
        {
            //nesnem örneklendiğinde default olarak yapıcı metodum çalışıcak

            //yapıcı metoda diyeceğim ki bu nesne örneklendiği zaman sen git bir metot yardımıyla bir değer üret ürettiğin değeri içeride private olarak duran fieldın içerisine ata
            //içeride private olarak saklamış olduğum field'a değer atayacağım.
            this.id = IDUret();
        }



        #region 2.Kısım
        int id;            //eğer herhangi bir erişim belirleyicisi yazmazsanız default olarak c# bunu private kabul eder.

        public int ID//property ismim
        {
            //get bloğunu kullanarak içeride private olarak saklamış olduğum değerimi property yardımıyla onu çağıran kod parçasına gönderiyorum.İçerideki private field içinde bulunan değeri alıyorum property yardımıyla onu çağıran koda okuma yapıyoruz 
            get
            {
                return this.id;     //içerideki private fieldımı dış katmana gönderdim
            }

            private set//ben dışarıdan bir değer set edilebilsin istemiyorum..
            {
                this.id = value;
            }
        }


        private int IDUret()
        {
            Random Rnd = new Random();
            return Rnd.Next(10000,90000);
        }




        #endregion

        public string isim;
        public string soyisim;



        #region 1. Kısım
        private string emailAdres;
        //private: müşteri class'ının içerisinde kullanılabilen bir field tanımı yaptım.Bunun adı emailadres


        //Class=> property(özellikler)  
        //emailAdres kısmını private olarak yalıttığımızda dış dünyadan değeri alabilmek için bir property tanımı yapıcağız.Property tanımı içerisinde de get ve set adında 2 bloğumuz bulunmaktadır. 

        public string EmailAdres
        {
            //get almak demek Kim alıyor? class'ı çağıran programcı
            //get metodu değeri karşıya gösterir
            //get; //database veya farklı bir veri kaynağı..class çağıran programcıya datayı gösterdiğimiz kısım..

            // set;//ben bu müşteri class'ı içerisindeki private olarak işaretlemiş olduğum emailAdres ine değer ataması yaptığım kısım
            //dış dünyadan alınan datanın içeride private olarak saklanan field içerisine değer atandığı kısım

            //bana değer geldiğinde set bloğum çalışacak=> VALUE dediğimiz anahtar kelime ile ben bana gelen değeri yakalayabiliyorum
            set {
                this.emailAdres = value;    //value'nun içinde=> yekinci@hotmail.com bilgisi bulunuyor
                                            //ben bu bilgiyi nereye atayacağım=>Bu classın içerisinde bulunan emailadres olarak yazmış olduğum ve private olarak saklamış olduğum field'ın içerisine atayacağım
            }
            

            //Bu sefer ben neyi get ediceğim ? Neyi karşı tarafa göndereceğim
            get
            {
                return this.emailAdres;         //içeride private olarak saklamış olduğum fieldın içindeki değeri bu property yardımıyla onu çağıran kişiye gönder.
            }

            //encapsulation :classın içerisindeki fielda giden datanın gitme ve o dataya ulaşma bölümlerinin detaylandırıldığımız kısıma biz encapsulation deriz

        }
        #endregion


        #region    Example

        string _tckimliknumarasi;

        public string TCKimlikNumarasi
        {
            set
            {
                if (TCKimlikNumarasi.Length == 11)
                {
                    bool bayrak = false;
                    for (int i=0; i<value.Length;i++)
                    {
                        bool karakterKontrol = char.IsNumber(value[i]);
                        if (karakterKontrol)
                        {
                            //sayısal değer demektir.
                        }
                        else
                        {
                            bayrak = true;
                            break;
                        }
                    }
                    if (bayrak)
                    {
                        Console.WriteLine("TC kimlik numarası içindeki değerler sayısal olmalıdır.");
                    }
                    else
                    {
                        this._tckimliknumarasi = value;
                    }
                }
                else
                {
                    Console.WriteLine("TC kimlik Numarası 11 hane olmalıdır.");
                }
            }
             get
            {
                //return this._tckimliknumarasi;
                return _tckimliknumarasi.Substring(0, 3);   
            }           

        }
        #endregion



    }
}
