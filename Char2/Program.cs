using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Char2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("... YGS DERSLERİ MENÜSÜ...");
            Console.WriteLine("Türkçe...");
            Console.WriteLine("Matematik...");
            Console.WriteLine("Sosyal...");
            Console.WriteLine("Fen... \n");
            Console.WriteLine("Hangi Dersin Bilgilerini Görmek İstersiniz: ");

            char ders;
            ders = Convert.ToChar(Console.ReadLine());

            switch (ders)
            {
                case 't' :Console.Write("Türkçe dersi paragraf ağırlıklıdır.");
                    break;
                case 'T':
                    Console.Write("Türkçe dersi paragraf ağırlıklıdır.");
                    break;
                case 'M': Console.WriteLine("Matematik dersi problem ağırlıklıdır");
                    break;
                case 'm':Console.WriteLine("Matematik dersi problem ağırlıklıdır");
                    break;
                case 'S': Console.WriteLine("Sosyal dersi tarih ve coğrafya ağırlıklıdır.");
                    break;
                case 's': Console.WriteLine("Sosyal dersi tarih ve coğrafya ağırlıklıdır");
                    break;
                case 'F': Console.WriteLine("Fen dersi fizik,kimya,biyoloji ağırlıklıdır");
                    break;
                case 'f': Console.WriteLine("Fen dersi fizik,kimya,biyoloji ağırlıklıdır");
                    break;

                default: Console.WriteLine("Hatalı bir giriş yaptınız tekrar deneyiniz");
                    break;
            }


            //if (ders == 'T' || ders == 't')
            //{
            //    Console.WriteLine("Türkçe dersi paragraf ağırlıklıdır.");
            //}
            //else if (ders == 'M' || ders == 'm')
            //{
            //    Console.WriteLine("Matematik dersi problem ağırlıklıdır.");
            //}
            //else if (ders == 'S' || ders == 's')
            //{
            //    Console.WriteLine("Sosyal tarih ve coğrafya ağırlıklıdır.");
            //}
            //else if (ders == 'F' || ders == 'f')
            //{
            //    Console.WriteLine("Fen fizik,kimya,coğrafya ağırlıklıdır.");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı bir giriş yaptınız.");
            //}


            Console.ReadLine();
        }
    }
}
