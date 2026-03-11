using System;

namespace Lab2
{
    internal class task3
    {
        static int[,] Input(out int n)
        {
            Console.Write("Input n = ");
            string input = Console.ReadLine() ?? "";
            if (!int.TryParse(input, out n)) n = 0;

            int[,] a = new int[n, n];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    Console.Write("a[{0},{1}]= ", i, j);
                    string line = Console.ReadLine() ?? "";
                    if (!int.TryParse(line, out int value)) value = 0;
                    a[i, j] = value;
                }
            }
            return a;
        }

        static void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); ++i)
            {
                for (int j = 0; j < a.GetLength(1); ++j)
                {
                    Console.Write("{0,5} ", a[i, j]);
                }
                Console.WriteLine();
            }
        }

        static int Rezalt(int[,] a)
        {
            int n = a.GetLength(0);
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += a[i, n - 1 - i];
            }
            return sum;
        }

        public static void Run()
        {
            int n;
            int[,] myArray = Input(out n);

            Console.WriteLine("\nInitial array:");
            Print(myArray);

            int sum = Rezalt(myArray);

            Console.WriteLine("\nSum of elements of the side diagonal = {0}", sum);
        }
    }
}