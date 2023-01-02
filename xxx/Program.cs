using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacity = 0;
            int count = 0;

            ArrayList a1 = new ArrayList();

            a1.Add("yasin ekinci");
            capacity = a1.Capacity;
            count = a1.Count;

            a1.Add(100);


            ArrayList a2 = new ArrayList();
            a2.Add("Cengiz");
            a2.Add("Atilla");
            a2.Add("Csharp");

            capacity = a2.Capacity;
            count = a2.Count;

            a1.AddRange(a2);
            capacity = a1.Capacity;
            count = a1.Count;


            if (a1.Contains("Csharp"))
            {
                int indexDegeri = a1.IndexOf("Csharp");
                a1.RemoveAt(indexDegeri);
            }

            object o1 = a1[0];
            string s1 = a1[1].ToString();
            int i1 = (int)a1[1];

            bool kontrol1 = a1.Contains("yasin ekinci");
            bool kontrol2 = a1.Contains(90);

            a1.Reverse();
            a1.Remove(100);
            a1.Add("beşiktaş");
            a1.Sort();

            a1.Remove("yasin ekinci");
            a1.RemoveRange(0, 2);
            a1.RemoveAt(0);
                      
                        
                       
                       
                        
            
            object[] oo = a1.ToArray();

            a1.Clear();
            a1.TrimToSize();


            Console.ReadLine();
        }
    }
}
