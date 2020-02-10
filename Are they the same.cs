
//https://www.codewars.com/kata/550498447451fbbd7600041c/train/csharp

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

      


        public static bool comp(int[] a, int[] b)
        {

            if (a == null || b == null)
            {
                return false;
            }
         

            if (a.Length != b.Length)
            {
                return false;
            }

            Dictionary<int, int> dic_a = new Dictionary<int, int>();
            Dictionary<int, int> dic_b = new Dictionary<int, int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (dic_a.ContainsKey(a[i]))
                {
                    dic_a[a[i]]++;
                }
                else
                {
                    dic_a[a[i]] = 1;
                }

                if (dic_b.ContainsKey(b[i]))
                {
                    dic_b[b[i]]++;
                }
                else
                {
                    dic_b[b[i]] = 1;
                }
            }

            

            for (int i = 0; i < a.Length; i++)
            {
                if (dic_b.ContainsKey(a[i] * a[i]))
                {
                    if (dic_b[a[i] * a[i]] != dic_a[a[i]])
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }

                if (dic_a.ContainsKey((int)Math.Sqrt(b[i])))
                {
                    if (dic_a[(int)Math.Sqrt(b[i])] != dic_b[b[i]])
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }


            return true;

        }


        static void Main(string[] args)
        {
        }
    }
}
