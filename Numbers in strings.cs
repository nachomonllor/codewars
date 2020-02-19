https://www.codewars.com/kata/numbers-in-strings/csharp

public static int Solve(string s)
        {
            StringBuilder concat = new StringBuilder();
            int max = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsNumber(s[i]))
                {
                    concat.Append(s[i]);
                }
                else
                {
                    if (concat.ToString().Length > 0)
                    {
                        max = Math.Max(max, int.Parse(concat.ToString()));
                    }
                    concat = new StringBuilder();
                }
            }
            if (concat.ToString().Length > 0)
            {
                max = Math.Max(max, int.Parse(concat.ToString()));
            }
            return max;
        }