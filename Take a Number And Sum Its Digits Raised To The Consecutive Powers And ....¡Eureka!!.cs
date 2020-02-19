  public static long[] SumDigPow(long a, long b)
        {
            // your code
            List<long> lista = new List<long>();
            for (long i = a; i <= b; i++)
            {
                long sumapotencias = 0;
                string nums = i + "";
                for (int k = 0;k < nums.Length; k++)
                {
                    sumapotencias += (long)Math.Pow(nums[k] - '0', k + 1);
                }

                if (sumapotencias == i)
                {
                    lista.Add(i);
                }
            }
            return lista.ToArray();
        }