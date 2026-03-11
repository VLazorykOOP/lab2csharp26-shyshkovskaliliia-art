using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Tests
{
    public static class Task3
    {
        public static int GetSideDiagonalSum(int[,] a)
        {
            int n = a.GetLength(0);
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += a[i, n - 1 - i];
            }
            return sum;
        }
    }
}
