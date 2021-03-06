https://www.codewars.com/kata/5ce399e0047a45001c853c2b/train/csharp

public static int[] PartsSums(int[] ls)
    {
            int total = ls.Sum();
            List<int> ans = new List<int>();
            ans.Add(total);
            for (int i = 0; i < ls.Length; i++)
            {
                total -= ls[i];
                ans.Add(total);
            }
            return ans.ToArray();
    }