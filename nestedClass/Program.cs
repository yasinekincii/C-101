using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nestedClass
{
    internal class Program
    {
        static void Main(string[] args)
        {

            A a = new A();
            a.PropA = 4;//a. diyince propa ya erişebiliyorum

            //peki b'ye nasıl erişeceğim b diye bir şey yok
            //bunun için a.b demem gerekli

            A.B b = new A.B();
            b.PropB = 5;



            Console.ReadLine();
        }
    }


    class A
    {
        public int PropA { get; set; }

        public A()
        {
            Console.WriteLine("A sınıfı");
        }


        public class B
        {
            public int PropB { get; set; }

            public B()
            {
                Console.WriteLine("B sınıfı");
            }

        }
    }
}
