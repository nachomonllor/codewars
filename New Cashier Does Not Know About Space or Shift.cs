https://www.codewars.com/kata/new-cashier-does-not-know-about-space-or-shift/csharp

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {


        public static string GetOrder(string input)
        {

            HashSet<string> hash = new HashSet<string>(new string[]{ "Burger",
                                                                "Fries",
                                                                "Chicken",
                                                                "Pizza",
                                                                "Sandwich",
                                                                "Onionrings",
                                                                "Milkshake",
                                                                "Coke"});
            Dictionary<string, int> dic = new Dictionary<string, int>();

            for (int i = 0; i < input.Length; i++)
            {
                foreach (string item in hash)
                {
                    if (i + item.Length <= input.Length && input.Substring(i, item.Length) == item.ToLower())
                    {
                        //Console.WriteLine(item);
                        if (dic.ContainsKey(item))
                        {
                            dic[item]++;
                        }
                        else
                        {
                            dic[item] = 1;
                        }
                    }
                }
            }



            StringBuilder sb = new StringBuilder();

            foreach (string item in hash)
            {
                if (dic.ContainsKey(item))
                {
                    for (int i = 0; i < dic[item]; i++)
                    {
                        //Console.WriteLine(item);
                        sb.Append(item);
                        sb.Append(' ');
                    }
                }
            }

            return sb.ToString().Trim();
        }

        static void Main(string[] args)
        {

            string s = "milkshakepizzachickenfriescokeburgerpizzasandwichmilkshakepizza";
                      //"Burger Fries Chicken Pizza Pizza Pizza Sandwich Milkshake Milkshake Coke"
           // Console.WriteLine(GetOrder(s));

            Console.WriteLine( GetOrder(s));

            Console.ReadLine();
        }
    }
}
