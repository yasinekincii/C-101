using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace arrayListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10 elemanlı(string) arraylist içindeli değerleri Z-A olacak şekilde sıralayın

            ArrayList a = new ArrayList();
            a.Add("a");
            a.Add("e");
            a.Add("f");
            a.Add("d");
            a.Add("z");
            a.Add("b");
            a.Add("c");

            a.Sort();
            a.Reverse();
        }
    }
}
