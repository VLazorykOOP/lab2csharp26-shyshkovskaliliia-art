using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Tests
{
    public static class Task2
    {
        public static void ReplaceMaxWithZero(double[] a)
        {
            if (a == null || a.Length == 0) return;

            double maxVal = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > maxVal) maxVal = a[i];
            }

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == maxVal) a[i] = 0;
            }
        }
    }
}

