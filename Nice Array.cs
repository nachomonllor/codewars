 https://www.codewars.com/kata/nice-array/csharp

public static bool IsNice(int[] arr)
        {

            if (arr == null || arr.Length == 0) return false;

            HashSet<int> hash = new HashSet<int>(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                if (!hash.Contains(arr[i]+1) && !hash.Contains(arr[i]-1))
                {
                    return false;
                }

            }
            return true;

        }