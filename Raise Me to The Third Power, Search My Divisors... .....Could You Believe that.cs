   public static long IntCubeSumDiv(long n)
        {
            // your code
           // sieve(201);
            int max = 500000;
            int[] divisor = new int[max + 1];
            
            for (int i = 1; i <= max; ++i)
            {
                for (int j = i; j < max; j += i)
                {
                    //divisor[j].Add(i);
                    divisor[j] += i;
                }
            }


            int t = 0;
            long num = 1;
            while (t <= n)
            {

                num++;
                if ((num * num * num) % divisor[num]  == 0)
                {
                    t++;
                }
                if (t == n)
                {
                    break;
                }
                
            }

            return num;

        }