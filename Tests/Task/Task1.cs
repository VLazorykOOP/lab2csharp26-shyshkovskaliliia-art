using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Tests
{
    public static class Task1
    {
        public static void Process1DArray(int[] a, int min, int max)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= min && a[i] <= max)
                    a[i] = 0;
            }
        }

        public static void Process2DArray(int[,] matrix, int min, int max)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] >= min && matrix[i, j] <= max)
                        matrix[i, j] = 0;
                }
            }
        }
    }
}
