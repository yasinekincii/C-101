using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayListExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int secim;
            ArrayList d1 = new ArrayList();

            do
            {
                Console.WriteLine("1=Değer Ekle \n2=DeğerListele \n3:Değer Ara \n4:Değer Düzenle \n5:Değer Sil \n6:Uygulama Çıkış \nSeçiniz: ");
                 secim= Convert.ToInt32(Console.ReadLine());

                if (secim == 1)
                {
                    Console.Write("Listenize eklemek istediğiniz değeri giriniz: ");
                    d1.Add(Console.ReadLine());
                }
                else if (secim == 2)
                {

                }
                else if (secim==3)
                {
                    Console.Write("Aramak istediğiniz değeri giriniz: ");
                    string deger = Console.ReadLine();
                    if (d1.Contains(deger))
                    {
                        Console.WriteLine("Girdiğiniz değer Koleksiyonda bulunur");
                    }
                    else
                    {
                        Console.WriteLine("Girdiğiniz değer koleksiyonda bulunmuyor");
                    }
                }
                else if (secim == 4)
                {
                    Console.WriteLine("Düzenlemek istediğiniz değeri giriniz");
                    string deger = Console.ReadLine();
                    if (d1.Contains(deger))
                    {
                        Console.WriteLine("Girdiğiniz değer Koleksiyonda bulunuyor.Değere ne yapmak istersiniz? \n1)Silmek\n2)değiştirmek");
                        int x = Convert.ToInt32(Console.ReadLine());
                        if (x == 1)
                        {
                            d1.Remove(deger);
                        }
                        else if (x == 2)
                        {
                           int y= d1.IndexOf(deger);
                            d1.Remove(deger);
                            d1[y]= Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Hatalı bir giriş yaptınız!!");
                        }
                    }
                }               
                else if (secim==5)
                {
                    Console.WriteLine("Silmek istediğiniz değeri giriniz");
                    string deger = Console.ReadLine();
                    if (d1.Contains(deger))
                    {
                        d1.Remove(deger);
                    }
                    else
                    {
                        Console.WriteLine("Girdiğiniz değer koleksiyonda bulunmuyor.");
                    }
                }
                else if (secim == 6)
                {
                    Console.WriteLine("Uygulamadan ayrılıyorsunuz..İyi günler");
                }
                else
                {
                    Console.WriteLine("Hatalı bir giriş yaptınız");
                }

            } while (secim==1 || secim == 2 || secim==3 || secim == 4 || secim == 5);

            Console.ReadLine();
        }
    }
}
