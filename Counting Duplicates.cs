https://www.codewars.com/kata/54bf1c2cd5b56cc47f0007a1/csharp

public static int DuplicateCount(string str)
        {

            int[] hash = new int[256];

            str = str.ToLower();

            int cont = 0;
            for (int i = 0; i < str.Length; i++)
            {
                hash[str[i]]++;
                if (hash[str[i]] == 2)
                {
                    cont++;
                }

            }
 
            return cont;

        }