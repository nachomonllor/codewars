 https://www.codewars.com/kata/59b0fd62cf2497d79c000108/solutions/csharp

public static int FindPivotIndex( int[] integerArray)
        {

            int sum = integerArray.Sum();

            int mitadSum = 0;
            for (int i = 0; i < integerArray.Length; i++)
            {
                if (mitadSum == sum - mitadSum - integerArray[i]) return i;
                mitadSum += integerArray[i];
            }
            return -1;
        }