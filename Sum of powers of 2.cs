
//https://www.codewars.com/kata/5d9f95424a336600278a9632/csharp

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        public static int[] Powers(int n)
        {
            // your code here
            List<int> potencias2 = new List<int>();
            int prod = 1;
            potencias2.Add(prod);
            for (int i = 0; prod <= n; i++)
            {
                prod *= 2;
                potencias2.Add(prod);
            }

            List<int> ans = new List<int>();

            for (int i = potencias2.Count - 1; i >= 0; i--)
            {
                if (n - potencias2[i] >= 0)
                {
                    n -= potencias2[i];
                    ans.Add(potencias2[i]);
                }

            }
            ans.Reverse();

            return ans.ToArray();
        }

        static void Main(string[] args)
        {

            Powers(6);



            Console.ReadLine();
        }

    }
}
