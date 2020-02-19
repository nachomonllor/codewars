 https://www.codewars.com/kata/convert-a-string-to-a-number/csharp

public static int StringToNumber(String str)
        {
            int ini = 0;
            if (str[0] == '-')
            {
                ini = 1;
            }

            int ans = 0;
            for (int i = ini; i < str.Length; i++)
            {
                ans = ans * 10 + (str[i] - '0');
            }
            if (ini == 1) ans *= -1;

            return ans;
        }