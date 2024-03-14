// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.


// using System;

// class Program
// {
//     static void PrintRange(int m, int n)
//     {
//         if (m <= n)
//         {
//             Console.Write(m + " ");
//             PrintRange(m + 1, n);
//         }
//     }

//     static void Main(string[] args)
//     {
//         // Задайте значения M и N
//         int M = 50;
//         int N = 60;

//         Console.WriteLine("Натуральные числа от " + M + " до " + N + " включительно:");
//         PrintRange(M, N);
//     }
// }

// Задача 2. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// using System;

// class Program
// {
//     static int Ackermann(int m, int n)
//     {
//         if (m == 0)
//         {
//             return n + 1;
//         }
//         else if (n == 0)
//         {
//             return Ackermann(m - 1, 1);
//         }
//         else
//         {
//             return Ackermann(m - 1, Ackermann(m, n - 1));
//         }
//     }

//     static void Main(string[] args)
//     {
//         // Введите значения m и n
//         int m = 2;
//         int n = 3;

//         Console.WriteLine("Результат функции Аккермана для m = " + m + " и n = " + n + " равен " + Ackermann(m, n));
//     }
// }

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

// using System;

// class Program
// {
//     static void PrintArrayReverse(int[] arr, int index)
//     {
//         if (index >= 0)
//         {
//             Console.Write(arr[index] + " ");
//             PrintArrayReverse(arr, index - 1);
//         }
//     }

//     static void Main(string[] args)
//     {
//         int[] array = { 9, 3, 6, 17, 8 };

//         Console.WriteLine("Элементы массива в обратном порядке:");
//         PrintArrayReverse(array, array.Length - 1);
//     }
// }