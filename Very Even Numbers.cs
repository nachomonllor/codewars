//https://www.codewars.com/kata/58c9322bedb4235468000019/solutions/csharp

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        

        public static bool IsVeryEvenNumber(long number)
        {
            long c = number;
            while (c >= 10)
            {
                long sum = 0;
                while (c > 0)
                {
                    sum += c % 10;
                    c /= 10;
                }
                c = sum;
            }
            return c % 2 == 0;

        }

        static void Main(string[] args)
        {
          //  Console.WriteLine(DescomponerAUnDigito(666));
            Console.WriteLine(IsVeryEvenNumber(000005));

            Console.ReadLine();
        }
    }
}
