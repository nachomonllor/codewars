  //https://www.codewars.com/kata/sudoku-solution-validator/train/csharp

public static bool ValidateSolution(int[][] board)
    {
        //comprobar fila por fila
        for (int i = 0; i < 9; i++)
        {
            HashSet<int> filaActual = new HashSet<int>();
            for (int j = 0; j < 9; j++)
            {
                //if (char.IsNumber(board[i][j]))
                {
                    if (filaActual.Contains(board[i][j]))
                    {
                        return false;
                    }
                    filaActual.Add(board[i][j]);
                }
            }
        }

        //comprobar columna por columna
        for (int j = 0; j < 9; j++)
        {
            HashSet<int> colActual = new HashSet<int>();
            for (int i = 0; i < 9; i++)
            {
                //if (char.IsNumber(board[i][j]))
                {
                    if (colActual.Contains(board[i][j]))
                    {
                        return false;
                    }
                    colActual.Add(board[i][j]);
                }
            }

        }

        for (int fila = 0; fila < 9; fila += 3)
        {
            for (int col = 0; col < 9; col += 3)
            {
                HashSet<int> cuadrante = new HashSet<int>();
                for (int i = fila; i < fila + 3; i++)
                {
                    for (int j = col; j < col + 3; j++)
                    {
                        //if (char.IsNumber(board[i][j]))
                        {
                            if (cuadrante.Contains(board[i][j]))
                            {
                                return false;
                            }
                            cuadrante.Add(board[i][j]);
                        }
                    }
                }
            }
        }

        return true;
    }
