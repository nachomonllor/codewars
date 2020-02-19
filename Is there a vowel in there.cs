https://www.codewars.com/kata/is-there-a-vowel-in-there/csharp

        public static object[] IsVow(object[] a)
        {
            //return a;

            string vocales = "aeiou";
            List<object> ans = new List<object>();
            for (int i = 0; i < a.Length; i++)
            {
                if (vocales.Contains((char)((int)a[i])))
                {
                    ans.Add(((char)((int)a[i])).ToString());
                }
                else
                {
                    ans.Add((int)a[i]);
                }
            }
            return ans.ToArray();
        }