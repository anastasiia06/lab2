using System;
using System.IO;

class Program
{
    static int[,] FromKeyboard()
    {
        Console.Write("Введіть розмір матриці M: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        Console.WriteLine("Введіть матрицю:");
        for (int i = 0; i < n; i++)
        {
            string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = int.Parse(parts[j]);
            }
        }
        return matrix;
    }
    static int[,] FromFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        int n = int.Parse(lines[0]); 
        int[,] matrix = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            string[] parts = lines[i + 1].Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = int.Parse(parts[j]);
            }
        }
        return matrix;
    }

    static void SwapMaxWithDiagonal(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            int maxIndex = 0;
            for (int j = 1; j < n; j++)
            {
                if (matrix[i, j] > matrix[i, maxIndex])
                {
                    maxIndex = j;
                }
            }
            int temp = matrix[i, maxIndex];
            matrix[i, maxIndex] = matrix[i, i];
            matrix[i, i] = temp;
        }
    }
    static void PrintMatrix(int[,] matrix, string message)
    {
        Console.WriteLine(message);
        int n = matrix.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j].ToString().PadLeft(4));
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        while (true) {
            
            Console.WriteLine("*** МЕНЮ ***");
            Console.WriteLine("1. Ввести матрицю з клавіатури");
            Console.WriteLine("2. Зчитати матрицю з файлу");
            int choice = int.Parse(Console.ReadLine());

            int[,] matrix;

            if (choice == 1)
            {
                matrix = FromKeyboard();
            }
            else if (choice == 2)
            {
                Console.Write("Введіть назву файлу: ");
                string filename = Console.ReadLine();
                matrix = FromFile(filename);
            }
            else
            {
                Console.WriteLine("Помилка!");
                return;
            }

            PrintMatrix(matrix, "Початкова матриця:");
            SwapMaxWithDiagonal(matrix);
            PrintMatrix(matrix, "Перетворена матриця:");

           
        }
    }
        
}
