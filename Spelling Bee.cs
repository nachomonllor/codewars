https://www.codewars.com/kata/spelling-bee/csharp


 public static int HowManyBees(char[][] hive)
        {

            if (hive == null || hive.Length == 0) return 0;

            int cont = 0;
            for (int i = 0; i < hive.Length; i++)
            {
                StringBuilder fila = new StringBuilder();
                for (int j = 0; j < hive[i].Length; j++)
                {
                    fila.Append(hive[i][j]);
                }
                string f = fila.ToString();
                for (int j = 0; j + 3 <= f.Length; j++)
                {
                    if (f.Substring(j, 3) == "bee" || f.Substring(j, 3) == "eeb")
                    {
                        cont++;
                    }
                }
            }

            string[] s_columnas = new string[hive[0].Length];
            for (int j = 0; j < hive[0].Length; j++)
            {
                StringBuilder columna = new StringBuilder();
                for (int i = 0; i < hive.Length; i++)
                {
                    columna.Append(hive[i][j]);
                }
                //s_columnas[j] = columna.ToString();
                string c = columna.ToString();
                for (int i = 0; i + 3 <= c.Length; i++)
                {
                    if (c.Substring(i, 3) == "bee" || c.Substring(i, 3) == "eeb")
                    {
                        cont++;
                    }
                }
            }


            return cont;

        }


---------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        public static int HowManyBees(char[][] hive)
        {

            if (hive == null || hive.Length == 0) return 0;

            string[] s = new string[hive.Length];
            for (int i = 0; i < hive.Length; i++)
            {
                StringBuilder fila = new StringBuilder();
                for (int j = 0; j < hive[i].Length; j++)
                {
                    fila.Append(hive[i][j]);
                }
                s[i] = fila.ToString();
            }

            int cont = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j + 3 <= s[i].Length; j++)
                {
                    if (s[i].Substring(j, 3) == "bee" || s[i].Substring(j, 3) == "eeb")
                    {
                        cont++;
                    }
                }
            }

            string[] s_columnas = new string[hive[0].Length];
            for (int j = 0; j < hive [0].Length; j++)
            {
                StringBuilder columna = new StringBuilder();
                for (int i = 0; i < hive.Length; i++)
                {
                    columna.Append(hive[i][j]);
                }
                s_columnas[j] = columna.ToString();
            }

            for (int i = 0; i < s_columnas.Length; i++)
            {
                for (int j = 0; j + 3 <= s_columnas[i].Length; j++)
                {
                    if (s_columnas[i].Substring(j, 3) == "bee" || s_columnas[i].Substring(j, 3) == "eeb")
                    {
                        cont++;
                    }
                }
            }

            return cont;
        }

        static void Main(string[] args)
        {
            char[][] s = {
            "bee.bee".ToCharArray(),     
            ".e..e..".ToCharArray(),
            ".b..eeb".ToCharArray()};

            Console.WriteLine(HowManyBees(s));


            Console.ReadLine();
        }
    }
}
