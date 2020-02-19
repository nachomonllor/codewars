namespace myjinxin
{
    using System;
    
    public class Kata
    {
        long gcd(long a, long b)
        {
            if (a % b != 0)
                return gcd(b, a % b);
            else
                return b;
        }

        

         public double LCMm2n(int m, int n)
        {
            //coding and coding..
            if (m > n)
            {
                int temp = m;
                m = n;
               
                n = temp;
            }

            long ans = 1;
            for (long i = m; i <= n; i++)
                ans = (ans * i) / (gcd(ans, i));
            return ans;
           


        }
    }
}