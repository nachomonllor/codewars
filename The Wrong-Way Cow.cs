 https://www.codewars.com/kata/the-wrong-way-cow/csharp

public static int[] FindWrongWayCow(char[][] field)
        {
            // Your cow finding code here
            int[] res = new int[2];
            List<List<int>> coords = new List<List<int>>();
            for (int i = 0; i < 4; i++)
            {
                coords.Add(new List<int>(new int[] { 0, 0, 0 }));
            }
            //coords.Add(new List<int>(new int[] { 0, 0, 0 }));
            //coords.Add(new List<int>(new int[] { 0, 0, 0 }));
            //coords.Add(new List<int>(new int[] { 0, 0, 0 }));

            for (int i = 0; i < field.Length; i++)
            {

                for (int j = 0; j < field[i].Length; j++)
                {
                    if (field[i][j] == 'c')
                    {
                        if (i - 2 >= 0)
                        {
                            if (field[i - 1][j] == 'o' && field[i - 2][j] == 'w')
                            {
                                coords[0][0] = j;
                                coords[0][1] = i;
                                coords[0][2]++;
                            }
                        }

                        if (i + 2 < field.Length)
                        {
                            if (field[i + 1][j] == 'o' && field[i + 2][j] == 'w')
                            {
                                coords[1][0] = j;
                                coords[1][1] = i;
                                coords[1][2]++;
                            }
                        }

                        if (j - 2 >= 0)
                        {
                            if (field[i][j - 1] == 'o' && field[i][j - 2] == 'w')
                            {
                                coords[2][0] = j;
                                coords[2][1] = i;
                                coords[2][2]++;
                            }
                        }
                        if (j + 2 < field[i].Length)
                        {
                            if (field[i][j + 1] == 'o' && field[i][j + 2] == 'w')
                            {
                                coords[3][0] = j;
                                coords[3][1] = i;
                                coords[3][2]++;
                            }
                        }
                    }
                }
            }

            foreach (List<int> lista in coords)
            {
                if (lista[2] == 1)
                {
                    return new int[] { lista[0], lista[1] };
                }
            }

            return res;
        }
