https://www.codewars.com/kata/59922d2ab14298db2b00003a/solutions/csharp

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        public static long[] ThreeAmigos(int[] numbers)
        {

            //int[] ans = new int[3];
            List<long> ans = new List<long>();
            long mindif = long.MaxValue;
            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if ((numbers[i - 1] % 2 == 0 && numbers[i]%2 ==0 &&
                    numbers[i+1]%2==0) ||

                   (numbers[i - 1] % 2 != 0 && numbers[i] % 2 != 0 &&
                    numbers[i + 1] % 2 != 0))
                {
                    List<long> tres = new List<long>();
                    tres.Add(numbers[i - 1]);
                    tres.Add(numbers[i  ]);
                    tres.Add(numbers[i + 1]);

                    if (Math.Abs( tres.Max() - tres.Min()) < mindif)
                    {
                        ans = new List<long>();
                        ans.Add( numbers[i - 1]);
                        ans.Add( numbers[i]);
                        ans.Add( numbers[i + 1]);
                        mindif = Math.Abs( tres.Max() - tres.Min());
                    }
                }
            }

            return ans.ToArray() ;

        }


        static void Main(string[] args)
        {
            long[] ans = ThreeAmigos(long[] { 1, 2, 34, 2, 1, 5, 3, 5, 7, 234, 2, 1 });

            for (int i = 0; i < ans.Length; i++)
            {
                Console.Write(ans[i] + " ");
            }

            Console.ReadLine();
        }

    }
}
