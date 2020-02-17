//https://www.codewars.com/kata/55192f4ecd82ff826900089e/csharp

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static bool Divide(int weight)
        {
            //Do it here bro!

            for (int i = 1; i < weight; i++)
            {
                if ((weight - i) % 2 == 0 && i % 2 ==0) 
                {
                    return true;
                }

            }
            return false;
        }


        static void Main(string[] args)
        {


            Console.ReadLine();
        }
    }
}
