https://www.codewars.com/kata/54b42f9314d9229fd6000d9c/train/csharp

public class Kata
{
  public static string DuplicateEncode(string word)
  {
            word = word.ToLower();
            int[] count = new int[256];
            for (int i = 0; i < word.Length; i++) count[word[i]]++;
            
            string ans = "";
            for (int i = 0; i < word.Length; i++) ans = (count[word[i]] > 1) ? ans += ")" : ans += "(";

            return ans;
  }
}