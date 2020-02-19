using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Kata
{
  public static int SumMul(int n, int m)
  {
         if (m <= n || n <= 0 || m <= 0)
            {

             //   return 0;
                throw new ArgumentException();
            }
            int sum = 0;
            for (int i = n; i <= m; i += n)
            {
                sum += i;
            }
            return sum;
  }
}