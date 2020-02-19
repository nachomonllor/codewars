 
https://www.codewars.com/kata/youre-a-square/csharp

 public static bool IsSquare(int n)
        {
            //Your code goes here!

            if (n < 0) return false;

            int sqr = (int)Math.Sqrt(n);

            return sqr * sqr == n;

        }