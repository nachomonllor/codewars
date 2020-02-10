
//https://www.codewars.com/kata/5b39e3772ae7545f650000fc/train/csharp

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static string RemoveDuplicateWords(string s)
        {
            //throw new NotImplementedException();


            return string.Join(" ", new HashSet<string>(s.Split(' ')).ToArray());

        }

        static void Main(string[] args)
        {


            Console.ReadLine();
        }
    }
}
