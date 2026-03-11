using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Tests
{
    public static class Task4
    {
        public static int[] CountPositiveInRows(int[][] array)
        {
            if (array == null) return new int[0];

            int[] results = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                results[i] = array[i].Count(x => x > 0);
            }
            return results;

        }
    }
}
