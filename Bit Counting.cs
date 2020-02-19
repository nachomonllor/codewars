 https://www.codewars.com/kata/526571aae218b8ee490006f4/solutions/csharp

public static int CountBits(int n)
        {
            int cont = 0;
            while (n > 0)
            {
                if (n % 2 == 1)
                {
                    cont++;
                }
                n /= 2;
            }
            return cont;
        }