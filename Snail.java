https://www.codewars.com/kata/521c2db8ddc89b9b7a0000c1/solutions/java


/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javaapplication32;

/**
 *
 * @author Usuario
 */
public class JavaApplication32 {

    
    
    static int  CargarFilaArriba(int[] ans, int k, int en_fila, int[][] m, int col_izq, int col_der)
    {
        for (int i = col_izq; i <= col_der; i++)
        {
            //m[en_fila][i] = num++;
            //Console.Write(m[en_fila][i] + " ");
            ans[k++]= m[en_fila][i];
        }
        return k;
    }

    static int  CargarFilaAbajo(int[] ans, int k,  int en_fila, int[][] m, int col_izq, int col_der)
    {
        for (int i = col_der; i >= col_izq; i--)
        {
            //m[en_fila][i] = num++;
            //Console.Write(m[en_fila][i] + " ");
            ans[k++] = m[en_fila][i];
        }
        return k;
    }

    static int CargarColDer( int[] ans, int k, int en_col, int[][] m, int fila_arriba, int fila_abajo)
    {
        for (int i = fila_arriba; i <= fila_abajo; i++)
        {
            //m[i][en_col] = num++;
            //Console.Write(m[i][en_col] + " ");
            ans[k++] = m[i][en_col];
        }
        return k;
       
    }

    static int  CargarColIzq(int[] ans, int k,  int en_col, int[][] m, int fila_arriba, int fila_abajo)
    {
        for (int i = fila_abajo; i >= fila_arriba; i--)
        {
            //m[i][en_col] = num++;
            // Console.Write(m[i][en_col] + " ");
            ans[k++] = m[i][en_col];
        }
        return k;
    }



    //static int[][] spiralNumbers(int n)
    //static void spiralNumbers(int[][] matriz)
    static int[] snail(int[][] array)
    {
        if(array.length == 0) {
            return new int[0];
        }
        
        int i = 0;
        int n = array.length;
        int j = n;

        //int num = 1;
        int[] ans = new int[n*n];
        int k =0;

        int fila_arriba = 0, fila_abajo = n - 1;
        int col_izq = 0, col_der = n - 1;

        while (fila_arriba <= fila_abajo &&
            col_izq <= col_der)
        {
            k = CargarFilaArriba(ans, k, fila_arriba, array, col_izq, col_der);
            fila_arriba++;
            k = CargarColDer(ans, k, col_der, array, fila_arriba, fila_abajo);
            col_der--;
            k = CargarFilaAbajo(ans, k, fila_abajo, array, col_izq, col_der);
            fila_abajo--;
            k = CargarColIzq(ans, k, col_izq, array, fila_arriba, fila_abajo);
            col_izq++;
        }

        // return matriz;
        return ans;
    }

    
    
    public static void main(String[] args) {
        // TODO code application logic here
        
        int[][] array = {
                new int[] {1, 2, 3},
                new int[] {4, 5, 6},
                new int[] {7, 8, 9}
                };


        int[] ans = snail(array);
        
        for(int i =0; i<ans.length; i++) {
            System.out.print(ans[i] + " ");
        }
        
        
    }
    
    
    
}



------------------------------------------------------------------------------

public static int[] snail(int[][] array) {
     int dimension = array[0].length;
        int[] integer = new int[dimension*dimension];        
        int k = 0;
        int layer = 0;
        if(array==null) {
            return null;
        }        
        for (int i = 0; i <= (dimension-1)/2; i++) {
            for (int j = i; j < dimension - 1 -i; j++) {
                integer[k] = array[i][j];                
                integer[k + dimension - 1 - 2 * layer] = array[j][dimension -i -1];
                integer[k + 2 * (dimension -1) - 4 * layer] = array[dimension - i - 1][dimension - j - 1];
                integer[k + 3 * (dimension -1) - 6 * layer] = array[dimension - j - 1][i];
                k++;
            }
            k = k + 3 * (dimension -1)- 6 * layer;
            layer++;
        }
        if (dimension % 2 != 0) {
            integer[dimension * dimension-1] = array[(dimension - 1)/2][(dimension - 1 )/2];
        }
        return integer;
   } 
}

-----------------------------------------------------

public static int[] snail(int[][] array) {
      if (array[0].length == 0) return new int[0];
      int n = array.length;
      int[] answer = new int[n*n];
      int index=0;
      for (int i = 0; i<n/2; i++){
        for (int j = i; j < n-i; j++) answer[index++] = array[i][j];
        for (int j = i+1; j < n-i; j++) answer[index++] = array[j][n-i-1];
        for (int j = i+1; j < n-i; j++) answer[index++] = array[n-i-1][n-j-1];
        for (int j = i+1; j < n-i-1; j++) answer[index++] = array[n-j-1][i];
      }
      if (n%2 != 0) answer[index++] = array[n/2][n/2];
      return answer;
    } 

