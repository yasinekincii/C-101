using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayExample3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bu örneğimizde kullanıcıdan veriler alarak bu verileri bir dizi içerisine alacağız. Daha sonra kullanıcının girmiş olduğu bu verilerin alfabetik olarak sıralanmasını sağlayacağız. Örneğimizde öncelikle kullanıcıdan kaç adet veri gireceği bilgisini alarak kullanıcının girmiş olduğu sayı büyüklüğünde bir dizi oluşturacağız. Daha sonra kullanıcıdan veriler isteyerek bu diziyi dolduracağız.
            int arrayLength;

            Console.Write("Girilecek metin sayısı: ");
             arrayLength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------");

            string[] str = new string[arrayLength];

            Console.WriteLine("Eklemek istediğiniz isimleri giriniz:  \n--------------------");
            for(int i=0; i < str.Length; i++)
            {
                Console.Write(i+1 +". ismi giriniz: ");
                string text = Console.ReadLine();
                //Console.Clear();

                str[i] = text;
            }

            Console.WriteLine("\nSıralamadan Önce Liste\n--------------------");
            foreach(var element in str)
            {
                Console.WriteLine(element);
            }

            Array.Sort(str);

            Console.WriteLine("\nA'dan Z'ye sıralanmış hali: \n--------------------");
            foreach(var element in str)
            {
                Console.WriteLine(element);
            }

            
            Console.WriteLine("\nZ'den A'ya sıralanmış hali   \n--------------------");
            Array.Reverse(str);
            foreach(var element in str)
            {
                Console.WriteLine(element);
            }






        }
    }
}
