using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    internal class Program
    {
       
            // C# program to print reverse
            // of words in a string.
            
class GFG
        {
            static String wordReverse(String str)
            {
                int i = str.Length - 1;
                int start, end = i + 1;
                String result = "";

                while (i >= 0)
                {
                    if (str[i] == ' ')
                    {
                        start = i + 1;
                        while (start != end)
                            result += str[start++];

                        result += ' ';

                        end = i;
                    }
                    i--;
                }

                start = 0;
                while (start != end)
                    result += str[start++];

                return result;
            }

            // Driver code
            public static void Main()
            {
                String str = "I AM A GEEK";

                Console.Write(wordReverse(str));

                Console.ReadLine();
            }
        }

        // This code is contributed
        // by Akanksha Rai(Abby_akku)
       
    }
}

