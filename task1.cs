using System;
namespace Lab2
{
    internal class task1
    {
        public static void Run()
        {
            Console.WriteLine("1D array section ");
            Console.Write("Input the size of the array n: ");
            int n = int.Parse(Console.ReadLine() ?? "0");
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"array[{i}] = ");
                a[i] = int.Parse(Console.ReadLine() ?? "0");
            }

            Console.Write("Beginning of the interval (min): ");
            int min = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("End of the interval (max): ");
            int max = int.Parse(Console.ReadLine() ?? "0");

            for (int i = 0; i < n; i++)
            {
                if (a[i] >= min && a[i] <= max)
                    a[i] = 0;
            }

            Console.WriteLine("Result 1D array:");
            foreach (int x in a) Console.Write(x + " ");
            Console.WriteLine("\n");

            Console.WriteLine("2D array section");
            Console.Write("Input rows: ");
            int rows = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Input cols: ");
            int cols = int.Parse(Console.ReadLine() ?? "0");
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("matrix[{0},{1}] = ", i, j);
                    matrix[i, j] = int.Parse(Console.ReadLine() ?? "0");
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] >= min && matrix[i, j] <= max)
                        matrix[i, j] = 0;
                }
            }

            Console.WriteLine("Result 2D array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}