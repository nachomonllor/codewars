import java.util.*;
public class ArrayReverser
{
   public static String[] reverse(String[] a)
   {
           StringBuilder s = new StringBuilder();

            for (int i = 0; i < a.length; i++)
            {
                s.append(a[i]).append("");
            }
            //char[] rev = s.toCharArray();
            // (rev);
            
             s.reverse();

            //String x = new String(rev);


            List<String> ans = new ArrayList();


            int start = 0;
            for (int i = 0; i < a.length; i++)
            {
                ans.add(s.substring(start, start+ a[i].length()));
                start += a[i].length();
            }
            //Console.WriteLine(x);

            //return ans.ToArray();
            String[] res = new String[ans.size()];
            for(int i =0; i<ans.size(); i++) {
                res[i] = ans.get(i);
            }
            
            return res;
   }
}