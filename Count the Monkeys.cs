https://www.codewars.com/kata/count-the-monkeys/csharp

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {


        //public static int[] MonkeyCount(int n)
        //{
        //    int[] ans = new int[n];

        //    for (int i = 0; i < n; i++)
        //    {
        //        ans[i] = i + 1;
        //    }
        //    return ans;
        //}

        public static int[] MonkeyCount(int n)
        {
            return Enumerable.Range(1, n).ToArray();
        }

        static void Main(string[] args)
        {


            int[] arr = MonkeyCount(10);

            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            

            Console.ReadLine();
        }
    }
}
