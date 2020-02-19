 public static bool isAnagram(string test, string original)
        {

            //string testLimpio = "";
            List<char> testLista = new List<char>();
            for (int i = 0; i < test.Length; i++)
            {
                if (char.IsLetterOrDigit(test[i]))
                {
                    //testLimpio += test[i];
                    testLista.Add( char.ToLower( test[i]));
                }
            }
            //string originalLimpio = "";
            List<char> originalLista = new List<char>();
            for (int i = 0; i < original.Length; i++)
            {
                //originalLimpio += original[i];
                if (char.IsLetterOrDigit(original[i]))
                {
                    originalLista.Add(char.ToLower(original[i]));
                }
            }
            if (testLista.Count != originalLista.Count)
            {
                return false;
            }
            testLista.Sort();
            originalLista.Sort();

            for (int i = 0; i < testLista.Count; i++)
            {
                if (testLista[i] != originalLista[i])
                {
                    return false;
                }
            }
            return true;
        }