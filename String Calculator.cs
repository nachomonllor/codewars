//https://www.codewars.com/kata/55ffd58d186cc9394f0000cc/train/csharp

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static int AddStrings(string numbers)
        {

            string[] sp = numbers.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            int sum = 0;

            for (int i = 0; i < sp.Length; i++)
            {
                sum += int.Parse(sp[i]);
            }
            return sum;

        }



        static void Main(string[] args)
        {


            Console.ReadLine();
        }
    }
}
