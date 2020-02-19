https://www.codewars.com/kata/5574940eae1cf7d520000076/solutions/csharp


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {


        public static string OddLadder(int n)
        {

            if (n <= 0) return "";

            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= n; i += 2)
            {
                //sb.AppendLine(new string((char)i.ToString(), i));
                sb.AppendLine(string.Concat(Enumerable.Repeat(i.ToString(), i)));
            }


            return sb.ToString().TrimEnd('\n');
        }

        static void Main(string[] args)
        {

            Console.WriteLine(OddLadder(10));

            Console.ReadLine();
        }
    }
}
