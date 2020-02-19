https://www.codewars.com/kata/515f51d438015969f7000013/solutions/csharp

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Kata {
  public static int[][] Pyramid(int n) {
    // your code here
    int[][] ans = new int[n][];

            for (int i = 0; i < n; i++)
            {
                ans[i] = new int[i+1];
                for (int j = 0; j < i+1; j++)
                {
                    ans[i][j] = 1;
                }
            }
            return ans;
  }
}