// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.


using System;

class Program
{
    static void PrintRange(int m, int n)
    {
        if (m <= n)
        {
            Console.Write(m + " ");
            PrintRange(m + 1, n);
        }
    }

    static void Main(string[] args)
    {
        // Задайте значения M и N
        int M = 50;
        int N = 60;

        Console.WriteLine("Натуральные числа от " + M + " до " + N + " включительно:");
        PrintRange(M, N);
    }
}
