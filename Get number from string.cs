 https://www.codewars.com/kata/get-number-from-string/csharp

public static int getNumberFromString(string s)
        {
            string ans = "";
            foreach (char ch in s)
            {
                if (ch >= '0' && ch <= '9')
                {
                    ans += ch;
                }
            }
            return int.Parse( ans);
        }