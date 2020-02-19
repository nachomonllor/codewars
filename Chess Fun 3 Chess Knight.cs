https://www.codewars.com/kata/chess-fun-number-3-chess-knight/csharp


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        public int ChessKnight(string cell)
        {
            //coding and coding..

            char letra = cell[0];
            char num = cell[1];

            int cont = 0;

            if ((char)(letra - 2) >= 'a')
            {
                if (num - 1 >= '1')
                {
                    cont++;
                }
                if (num + 1 <= '8')
                {
                    cont++;
                }
            }
            if ((char)(letra + 2) <= 'h')
            {
                if (num - 1 >= '1')
                {
                    cont++;
                }
                if (num + 1 <= '8')
                {
                    cont++;
                }
            }
            if ((char)(num - 2) >= '1')
            {
                if ((char)(letra - 1) >= 'a')
                {
                    cont++;
                }
                if ((char)(letra + 1) <= 'h')
                {
                    cont++;
                }
            }
            if ((char)(num + 2) <= '8')
            {
                if ((char)(letra - 1) >= 'a')
                {
                    cont++;
                }
                if ((char)(letra + 1) <= 'h')
                {
                    cont++;
                }
            }

            return cont;

        }

        static void Main(string[] args)
        {


            Console.ReadLine();
        }
    }
}
