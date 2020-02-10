using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
                
namespace ConsoleApplication1
{           
    class Program
    {       
            
      


        public static long[] OddRow(int n)
        {
            ulong ini = (ulong)n * ((ulong)n - 1) + 1;

            long[] r = new long[n];
            for (int i = 0; i < n; i++)
            {
                r[i] = (long) ini;
                ini += 2;
            }
            return r;
        }

        static void Main(string[] args)
        {
            long[] r = OddRow(5);

            for (int i = 0; i < r.Length; i++)
            {
                Console.Write(r[i] + " ");
            }
                
            Console.ReadLine();
        }   

    }
}
