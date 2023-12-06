// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// void InputMatrix(int[,] matrix)
// {
//    for(int i = 0; i < matrix.GetLength(0); i++)
//    for(int j = 0; j < matrix.GetLength(1); j++)
//         matrix[i, j] = new Random().Next(10, 100);
// }

// void PrintMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write(matrix[i, j] + "\t");
//         Console.WriteLine();
//     }
// }

// Console.Clear();
// Console.WriteLine($"Введите координаты:");
// int x = Convert.ToInt32(Console.ReadLine());
// int y = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[3, 3];
// Console.WriteLine("Исходный массив: ");
// InputMatrix(matrix);
// PrintMatrix(matrix);
//             if ( x < 0 | x > matrix.GetLength(0) | y < 0 | y > matrix.GetLength(1))
//                 Console.Write("Элемент не существует  ");
//             else
//                 Console.Write("Значение элемента массива = {0}", matrix[x, y]);
        
//         Console.WriteLine();
//
// Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// void InputMatrix(int[,] matrix)
// {
//    for(int i = 0; i < matrix.GetLength(0); i++)
//    {
//    for(int j = 0; j < matrix.GetLength(1); j++)
//    {
//         matrix[i, j] = new Random().Next(10, 100);
//     }
// }
// }

// void PrintMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write(matrix[i, j] + "\t");
//             Console.WriteLine();
//     }
// }

// Console.Clear();
// Console.Write("Введите размеры матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// PrintMatrix(matrix);
// Console.WriteLine("Новый массив: ");
// for(int i = 0; i < matrix.GetLength(0); i++)
// {
// for(int j = 0; j < matrix.GetLength(1); j++)
//     {
//         int temp = matrix[0, j];
//         matrix[0, j] = matrix[(matrix.GetLength(1) - 1), j];
//         matrix[(matrix.GetLength(1) - 1), j] = temp;
//         Console.Write(matrix[i, j] + "\t");
//     }
// Console.WriteLine();
// }
// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// void InputMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//         for(int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(10, 100);
// }

// void PrintMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write(matrix[i, j] + "\t");
//             Console.WriteLine();
//     }
// }

// void SumInLines(int[,] matrix)
// {
//     int index = 0, minsum = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             sum += matrix[i, j];
//         }
//         Console.WriteLine($"Сумма {i + 1} строки = {sum}");
//         if (i == 0)
//         {
//             minsum = sum;
//         }
//         else if (sum < minsum)
//         {
//             minsum = sum;
//             index = i;
//             Console.WriteLine($"Строка с минимальной суммой элементов равна {index+1}. ");
//         }
        
//     }
// }

// Console.Clear();
// Console.Write("Введите размеры матрицы: ");
// int[] size = Console.ReadLine()!.Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// int[] array = new int[size[0]];
// InputMatrix(matrix);
// PrintMatrix(matrix);
// SumInLines(matrix);


