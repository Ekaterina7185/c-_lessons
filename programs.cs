// __________________________________________________________________________________________________________________________
// // Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

// Console.Clear();
// int x = 10;
// int[] array = new int[x];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(1, 101);  // [1, 100]
// Console.WriteLine(string.Join(", ", array));
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] >= 20 && array[i]<= 90)
//     {
//         count++;
//     }
// }
// System.Console.WriteLine("Количество элементов массива, значения которых лежат в отрезке [20,90]:" + $"{count}");
//___________________________________________________________________________________________________
// Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.
// Console.Clear();
// int x = 10;
// int[] array = new int[x];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(1, 101);  // [1, 100]
// Console.WriteLine(string.Join(", ", array));
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i]%2 ==0)
//     {
//         count++;
//     }
// }
// System.Console.WriteLine("Количество чётных чисел:" + $"{count}");
//____________________________________________________________________________________________________________________
// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

// Console.Clear();
// Console.Write("Введите длину массива: ");
// int x = Convert.ToInt32(Console.ReadLine());
// double [] array = new double[x];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().NextDouble()*100;  
// Console.WriteLine(string.Join(", ", array));

// double  min =  Int32.MaxValue;
// double  max =  Int32.MinValue;


// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] >max)
//     {
//        max = array[i];
//     }
//     if (array[i] <min)
//     {
//        min = array[i];
//     }
// }
// Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {max - min}");
// // _________________________________________________________________________________________________________
// Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. Размер массива должен быть равен количеству цифр.
// 
// Console.Clear();
// int[] array = new int[6];

// int k =  new Random().Next(1, 100001);  
// Console.WriteLine(k);

// for (int i = array.Length-1; i >= 0; i--)
// {
//     array[i] = k % 10;
//     k /= 10;
   
// }
// Console.WriteLine(string.Join(", ", (array)));
