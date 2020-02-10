
//https://www.codewars.com/kata/57eaeb9578748ff92a000009/csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static int SumMix(object[] x)
        {
            int sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                sum += int.Parse(x[i]+"");
            }
            return sum;

        }


        static void Main(string[] args)
        {


            Console.ReadLine();
        }
    }
}
