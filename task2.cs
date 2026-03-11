using System;
using System.Globalization; // Обов'язково додайте це для роботи з форматами

namespace Lab2
{
    internal class task2
    {
        public static void Run()
        {
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine() ?? "0");
            double[] a = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}] = ");
                string input = Console.ReadLine() ?? "0";
                a[i] = double.Parse(input.Replace(',', '.'), CultureInfo.InvariantCulture);
            }

            double maxVal = a[0];
            for (int i = 1; i < n; i++)
            {
                if (a[i] > maxVal) maxVal = a[i];
            }

            Console.WriteLine($"\nMax value: {maxVal.ToString(CultureInfo.InvariantCulture)}");

            for (int i = 0; i < n; i++)
            {
                if (a[i] == maxVal) a[i] = 0;
            }

            Console.WriteLine("Result:");
            foreach (double val in a)
            {
                Console.Write($"{val.ToString(CultureInfo.InvariantCulture)} ");
            }
            Console.WriteLine("\n");
        }
    }
}