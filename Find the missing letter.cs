https://www.codewars.com/kata/find-the-missing-letter/csharp

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {


        public static char FindMissingLetter(char[] array)
        {
            char minchar = array[0];
            //char maxchar = array.Max();

            char c = ' ';
            for (char ch = minchar;  ; ch++)
            {
                if (!array.Contains(ch))
                {
                    c = ch;
                    //return ch;
                    break;
                }
            }

            return c;
        }


       

    }
}
