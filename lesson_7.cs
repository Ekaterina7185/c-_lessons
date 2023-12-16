// Задача 1:Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
// 
// Console.Clear();
// Console.Write("Введите значение M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// void rec(int m, int n) 
// {
// if (m > n) 
// return;
// Console.Write($"{m}, ");
// rec(m+1, n);
// }
// rec(m, n);
// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// Console.Clear();
// Console.Write("Введите значение M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int akkerman(int m, int n)
// {
// if (m == 0) return n + 1;
// else if (n == 0) return akkerman(m-1, 1);
// else return akkerman(m-1, akkerman(m, n-1));
// }

// Console.Write($"Функция Аккермана равно {akkerman(m, n)} ");

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

// T[] Reverse<T>(T[] Arr)
// {
//     T[] ReverseArray = new T[Arr.Length];
//     for (int i = Arr.Length - 1; i >= 0; i--)
//     {
//         ReverseArray[Arr.Length - i - 1] = Arr[i];
//     }
//     return ReverseArray;
// }

// Console.Clear();
// Console.Write("Введите длину массива: ");
// int x = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[x];
// int i = 0;
// for (i = 0; i < array.Length; i++)
// array[i] = new Random().Next(1,100); 
// int[] ReverseArray = Reverse(array);
// Console.WriteLine(string.Join(" ", array));
// Console.WriteLine(string.Join(" ", ReverseArray));
