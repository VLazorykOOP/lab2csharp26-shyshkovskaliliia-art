using System;

namespace Lab2
{
    class Lab2App
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("=== Лабораторна робота №2 ===");
                Console.WriteLine("Оберіть завдання для виконання:");
                Console.WriteLine("1. Завдання 1 (Обнулення в інтервалі [min, max])");
                Console.WriteLine("2. Завдання 2 (Пошук та обнулення Max значення)");
                Console.WriteLine("3. Завдання 3 (Сума бічної діагоналі)");
                Console.WriteLine("4. Завдання 4 (Додатні елементи у східчастому масиві)");
                Console.WriteLine("0. Вихід");
                Console.WriteLine("-----------------------------");
                Console.Write("Ваш вибір: ");

                string choice = Console.ReadLine() ?? string.Empty;

                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        task1.Run();
                        break;
                    case "2":
                        task2.Run();
                        break;
                    case "3":
                        task3.Run();
                        break;
                    case "4":
                        task4.Run();
                        break;
                    case "0":
                        exit = true;
                        Console.WriteLine("Завершення роботи...");
                        continue;
                    default:
                        Console.WriteLine("Помилка: невірний вибір. Спробуйте ще раз.");
                        break;
                }

                Console.WriteLine("\nНатисніть [Enter], щоб повернутися до меню...");
                while (Console.ReadKey(true).Key != ConsoleKey.Enter)
                {
                }
            }
        }
    }
}