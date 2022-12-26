using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_1
{
    internal class Account
    {
        public Account()
        {

        }

        //kendi oluşturduğumuz sınıfta metot kullanalım.

        public string GetAccount(string userName)
        {
            if (!string.IsNullOrEmpty(userName))//userName null ya da boş değilse
                //null ise veya boş ise true değer döner
                //ünlem işareti(sağındakinin olumsuzluğunu alır)yani başına ğnlem koyarsak sağın false olma durumu benim için true dur demek
            {
                //işlem yap
            }

            if (string.IsNullOrWhiteSpace(userName))
            {
                //işlem yap
            }

            return "DJB";   
        }


        public string GetAccount(int userId)
        {
            string result = string.Empty;

            if (userId>0)
            {
                //..
                result = "yasin ekinci";
                return result;
            }
            else
            {
                throw new Exception("Hata!");
            }
           
        }


    }
}
