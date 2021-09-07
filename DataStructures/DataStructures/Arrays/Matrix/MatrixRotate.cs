using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace DataStructures.Arrays.Matrix
{
    public class MatrixRotate
    {
        public MatrixRotate()
        {
            TwoDMatrix(new int[][] {
                new int[] {1,2},
                new int[] {3,4}
            });
        }

        public int[][] TwoDMatrix(int[][] matrix)
        {
             int R = matrix.Length;
            // int C = matrix[0].Length;

            //int[][] ret = new int[C][R];
            //for (int i=0;i< R; i++)
            //{
            //    for(int j=0;j< C; j++)
            //    {
            //        int temp = matrix[i][j];
            //        matrix[i][j] = matrix[i+j][j];
            //        matrix[i+j][j] = temp;
            //    }
            //}

            return matrix;
        }
    }
}
