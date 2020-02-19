https://www.codewars.com/kata/find-the-parity-outlier/csharp

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        public static int Find(int[] integers)
        {
            int evenCount = 0;
            int oddCount = 0;
            int evenN = 0;
            int oddN = 0;
            foreach (int integer in integers)
            {
                if (integer % 2 == 1)
                {
                    oddCount++;
                    oddN = integer;
                }
                else
                {
                    evenCount++;
                    evenN = integer;
                }
            }
            return (oddCount > evenCount) ? evenN : oddN;
        }

        static int find(int[] integers)
        {

            int pares = 0, impares = 0;
            bool buscoelpar = false, buscoelimpar = false;
            List<int> listaImpares = new List<int>();
            List<int> listaPares = new List<int>();
            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[i] % 2 == 0)
                {
                    listaPares.Add(integers[i]);
                    pares++;
                }
                else if (integers[i] % 2 != 0)
                {
                    listaImpares.Add(integers[i]);
                    impares++;
                }
                if (pares > 1)
                {
                    buscoelimpar = true;
                }
                if (impares > 1)
                {
                    buscoelpar = true;

                }
                if (buscoelimpar)
                {
                    if (listaImpares.Count > 0)
                    {
                        return listaImpares[0];
                    }
                }
                if (buscoelpar)
                {
                    if (listaPares.Count > 0)
                    {
                        return listaPares[0];
                    }
                }
            }

            return -1;

        }

        static void Main(string[] args)
        {

            int[] arr = { 160, 3, 1719, 19, 11, 13, -21 };

            Console.WriteLine(find(arr));


            Console.ReadLine();
        }
    }
}
