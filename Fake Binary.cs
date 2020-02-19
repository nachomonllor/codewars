https://www.codewars.com/kata/fake-binary/csharp


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        //public static string FakeBin(string x)
        //{
            
        //    StringBuilder sb = new StringBuilder();
        //    for (int i = 0; i < x.Length; i++)
        //    {
        //        if (x[i] - '0' < 5)
        //        {
        //            sb.Append('0');
        //        }
        //        else
        //        {
        //            sb.Append('1');
        //        }
        //    }
        //    return sb.ToString();
        //}

        public static string FakeBin(string x)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char t in x)
            {
                sb.Append(t >= '5' ? '1' : '0');
            }

            return sb.ToString();
        }

        static void Main(string[] args)
        {
            



            Console.ReadLine();
        }
    }
}
