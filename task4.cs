using System;
using System.Linq; 

namespace Lab2
{
    internal class task4
    {
        static int[][] Input()
        {
            Console.Write("Input n = ");
            int n = int.Parse(Console.ReadLine() ?? "0");
            int[][] a = new int[n][];

            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine($"\nrow {i}:");
                Console.Write("Input elements: ");

                string input = Console.ReadLine() ?? "";
                a[i] = input.Split(new[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
            }
            return a;
        }

        public static void Run()
        {
            int[][] myArray = Input();

            Console.WriteLine("\nResult array:");
            foreach (var row in myArray)
            {
                Console.WriteLine(string.Join("\t", row));
            }

            Console.WriteLine("\nNumber of positive elements in each row:");
            for (int i = 0; i < myArray.Length; i++)
            {
                int count = myArray[i].Count(x => x > 0);
                Console.WriteLine($"row {i}: {count} positive");
            }
        }
    }
}