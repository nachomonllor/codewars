  https://www.codewars.com/kata/beginner-series-number-3-sum-of-numbers/csharp

public int GetSum(int a, int b)
 
       {

            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            return ((b * (b + 1)) / 2) - (( (a-1) * ( (a-1) + 1)) / 2);


        }