 public static bool LogicalCalc(bool[] array, string op)
        {
            //return false;

            bool ans = array[0];

            if (op == "AND")
            {
                for (int i = 1; i < array.Length; i++)
                {
                    ans = ans && array[i];
                }
            }
            else if (op == "OR")
            {
                for (int i = 1; i < array.Length; i++)
                {
                    ans = ans || array[i];
                }
            }
            else if (op == "XOR")
            {

                for (int i = 1; i < array.Length; i++)
                {
                    ans = ans ^ array[i];
                }
            }

            return ans;
        }