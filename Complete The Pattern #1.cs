using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static  string Pattern(int n)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    sb.Append(i);
                    
                }
                sb.Append("\n");
            }
            return sb.ToString().TrimEnd('\n');
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Pattern(5));


            Console.ReadLine();

        }
    }
}
