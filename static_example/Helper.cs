using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_example
{
    public static class Helper
    {
        //static olarak işaretlenmiş classlar örneklenemez..
        //Helper H1=new Helper();
        //============================================================================================
        //============================================================================================

        /*public void Test() { }
             //Bu bir static class olduğu için bunun içerisinde normal metotlar yazamazsın diyor
             //Zaten nesne örneğini alamıyorum yazsam da erişemeyeceğim(çünkü yazmış olduğum standart metotlar(static olmayan metotlar) nesne örneği alındıktan sonra erişilebilir olan metotlardır)
        */

        /*
         *   public string MyProperty { get; set; }
         *          Static olan class'lar içerisinde static olmayan field tanımları yapılamaz
         */

        //============================================================================================
        //============================================================================================

        /*
         * public Helper(){}    =>Standart yapıcı metot
         * 
         * nesne örneği alındığında çalışan bir metottur.Eğer müdahale edersek içerisine bir şey yazıyorduk.Müdahale etmez isek arka tarafta bize görünmeden kendisi çalışıyordu
         * 
         *Aynı model static olarak yapmış olduğum classlarımda da mevcuttur.Hiç ellemesek de arka tarafta static bir yapıcı metot vardır.
         *
         *static yapıcı metotlar standart yapıcı metotlar gibidir ama bu yapıcı metotlarımız public değil private'tır.
         *
        */

        //public Helper()
        //{
        //Her nesne örneği alındığında uygulama standart yapıcı metodu çalıştırır.(yani ben ne zaman new Personel() dersem standart yapıcı metodum çalışır)

        //}


        static Helper()
        {
            //Uygulama içerisinde istenildiği kadar çağrılsınlar sadece ilk çağrılmada çalışırlar..
            Console.WriteLine("Helper => Static class => static CTOR");
        }

        //============================================================================================
        //============================================================================================
        public static void emailGonder(string aliciEmailAdres, string konu, string icerik)
        {
            //Email gönderme işlemleri devam edecek..
            Console.WriteLine("Mail gönderim işlemi başarılı");
        }

    }
}
