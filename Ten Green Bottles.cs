https://www.codewars.com/kata/ten-green-bottles/csharp


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static string verso(int n)
        {
            string[] numbers = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten" };

            if (n == 1)
            {

                return "One green bottle hanging on the wall,\n" +
                        "One green bottle hanging on the wall,\n" +
                        "If that one green bottle should accidentally fall,\n" +
                        "There'll be no green bottles hanging on the wall.\n";
            }
            else if (n == 2)
            {


                return "Two green bottles hanging on the wall,\n" +
                        "Two green bottles hanging on the wall,\n" +
                        "And if one green bottle should accidentally fall,\n" +
                        "There'll be one green bottle hanging on the wall.\n";
            }

            string verso =
            numbers[n] + " green bottles hanging on the wall,\n" +
            numbers[n] + " green bottles hanging on the wall,\n" +
            "And if one green bottle should accidentally fall,\n" +
            "There'll be " + numbers[(n - 1)].ToLower() + " green bottles hanging on the wall.\n";

            return verso;
        }


        public static string TenGreenBottles(int n)
        {
            int botellas = n;
            StringBuilder sb = new StringBuilder();
            while (botellas > 0)
            {
                sb.AppendLine(verso(botellas));
                botellas--;
            }
            string ans = sb.ToString().TrimEnd('\n').TrimEnd('\n');
            return ans + "\n";
        }


        static void Main(string[] args)
        {

            Console.WriteLine( TenGreenBottles(10));

            Console.ReadLine();
        }
    }
}
