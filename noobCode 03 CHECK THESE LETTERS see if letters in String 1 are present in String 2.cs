
//https://www.codewars.com/kata/57470efebf81fea166001627/train/csharp

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        public static bool LetterCheck(string[] arr)
        {
            string a = arr[0].ToLower().Trim();
            string b = arr[1].ToLower().Trim();

            char[] dic_a = new char[26];
            char[] dic_b = new char[26];

            for (int i = 0; i < a.Length; i++) if (a[i] != ' ') dic_a[a[i] - 'a']++;
            for (int i = 0; i < b.Length; i++) if(b[i] != ' ') dic_b[b[i] - 'a']++;


            for (char ch = 'a'; ch <= 'z'; ch++)
                if (dic_a[ch - 'a'] < dic_b[ch - 'a'])
                    return false;

            return true;

        }


        static void Main(string[] args)
        {
            //string[] s = new string[] { "trances", "nectar" };
            string[] s = new string[] { "THE EYES", "they see" };
            Console.WriteLine(LetterCheck(s));



            Console.ReadLine();

        }
    }
}
