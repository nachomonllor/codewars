https://www.codewars.com/kata/sum-consecutives/csharp

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static List<int> SumConsecutives(List<int> s)
        {
            List<int> lista = new List<int>();

            int i = 0;
            while (i < s.Count)
            {
                int actual = s[i];
                int suma = 0;
                while (i < s.Count && s[i] == actual)
                {
                    suma += s[i];
                    i++;
                }
                lista.Add(suma);
            }
            return lista;
        }


        static void Main(string[] args)
        {

            List<int> lista = new List<int> { 1, 4, 4, 4, 0, 4, 3, 3, 1 };

            List<int> ans = SumConsecutives(lista);

            foreach (int item in ans)
            {
                Console.Write(item + " ");
            }


            Console.ReadLine();
        }
    }
}
