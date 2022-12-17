using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassNote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            House objec = new House();
            objec.parking = true;
            objec.garden = true;
            objec.country = "Turkey";
            objec.town = "Kadıköy";
            objec.area = 45;

            Console.WriteLine("Does it have a parking spot= {0}\nDoes it have a garden= {1},\nWhere is this house? {2} \nWhich city is this house located on= {3}\nWhat is the size of the house= {4} m^2 ",objec.parking,objec.garden,objec.country,objec.town,objec.area);
            Console.WriteLine();

            objec.parking = false;
            objec.garden = true;
            objec.country = "Norway";
            objec.town = "Oslo";
            objec.area = 200;

            Console.WriteLine("Does it have a parking spot? "+objec.parking);
            Console.WriteLine("Does it have a garden? "+objec.garden);
            Console.WriteLine("Which country is this house located on? "+objec.country);
            Console.WriteLine("Which town is this house located on?"+objec.town);
            Console.WriteLine("What is the size of the house"+objec.area);


            Console.ReadLine();
        }
    }
}
