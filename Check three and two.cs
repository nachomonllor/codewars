//https://www.codewars.com/kata/5a9e86705ee396d6be000091/csharp

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        public static bool CheckThreeAndTwo(string[] array)
        {
            //throw (new NotImplementedException());
            Dictionary<string, int> dic = new Dictionary<string, int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (dic.ContainsKey(array[i]))
                {
                    dic[array[i]]++;
                }
                else
                {
                    dic[array[i]] = 1;
                }
            }

            bool tres = false, dos = false;
            foreach (KeyValuePair<string, int> kvp in dic)
            {
                if (kvp.Value % 2 == 0)
                {
                    dos = true;

                }
                if (kvp.Value % 3 == 0)
                {
                    tres = true;
                }
            }

            return dos && tres;

        }

        static void Main(string[] args)
        {


            Console.ReadLine();

        }
    }
}
