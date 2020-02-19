 https://www.codewars.com/kata/remember/csharp


public static List<char> Remember(string str)
        {
            HashSet<char> result = new HashSet<char>();
            HashSet<char> distinct = new HashSet<char>();

            for (int i = 0; i < str.Length; i++)
            {
                if (!distinct.Add(str[i]))
                    result.Add(str[i]);
            }

            return result.ToList();
        }

        public static List<char> Remember(string str)
        {

            Dictionary<char, int> dic = new Dictionary<char, int>();

            HashSet<char> rep = new HashSet<char>();
            for (int i = 0; i < str.Length; i++)
            {
                if (dic.ContainsKey(str[i])) rep.Add(str[i]);
                else dic.Add(str[i], 1);
            }

            return rep.ToList();
        }