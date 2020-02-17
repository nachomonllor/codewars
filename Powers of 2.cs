
//https://www.codewars.com/kata/57a083a57cb1f31db7000028/csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ConsoleApplication1
{
    class Program
    {

        public static BigInteger[] PowersOfTwo(int n)
        {
            //return new BigInteger[0];
            List<BigInteger> ans = new List<BigInteger>();
            ans.Add(1);
            for (int i = 1; i <= n; i++)
            {
                ans.Add(ans[i - 1] * 2);
            }
            return ans.ToArray();
        }

        static void Main(string[] args)
        {

            BigInteger[] r = PowersOfTwo(2);


            foreach (int item in r)
            {

                Console.Write(item + " ");

            }



            Console.ReadLine();
        }
    }
}
