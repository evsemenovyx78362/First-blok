// Console.Write("Введите первое число ");
// // int number1 = Convert.ToInt32(Console.ReadLine());
// // Console.Write("Введите второе число ");
// // int number2 = int.Parse(Console.ReadLine());
// // if(number1 == Math.Pow(number2,2))
// // {
// // Console.WriteLine("Да");
// // }
// // else
// // {
// // Console.WriteLine("Нет");
// // }
// // {
//     Console.WriteLine($"квадрат числа {number2} равен {number1 - 100}");
// }
// else
// {
//     Console.WriteLine("квадрат числа {1} НЕ равен {0}", number1, number2);
// }

// Console.WriteLine("Значение переменной number1 равно" + number1);

// if (number1 == Math.Pow(number2, 2)) Console.WriteLine($"квадрат числа {number2} равен {number1 - 100}");

// else Console.WriteLine("квадрат числа {1} НЕ равен {0}", number1, number2);

// Напишите программу, которая на вход принимает целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.

// Console.WriteLine("Введите целое число N ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num < 0)
// {
//     num = num * (- 1);
// }
// int index = - num;
// while (index <=num)
// {
//     Console.Write($"{index} ");
//     index++; //index = index = index + 1, index--; index = index - 1;
// }

// Задача 1. Внутри класса Answer напишите метод CompareNumbers, который на вход принимает два числа и выводит, 
// какое число большее, а какое меньшее.
// using System;
// using System.ComponentModel.DataAnnotations;

// public class Answer {
//     static void CompareNumbers(int firstNumber, int secondNumber)
//     {
//         // Введите свое решение ниже

//         int max = firstNumber;

//         if (firstNumber < secondNumber)
//         {
//             Console.WriteLine("второе число больше");
//         }
//         if (firstNumber > secondNumber)
//         {
//             Console.WriteLine("первое число больше");
//         }
//        if (firstNumber == secondNumber)
//         {
//             Console.WriteLine("числа равны");
//         }
        
//     }


//   // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int firstNumber, secondNumber;

//         if (args.Length >= 2) {
//             firstNumber = int.Parse(args[0]);
//             secondNumber = int.Parse(args[1]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             firstNumber = 5;
//             secondNumber = 5;
//         }

//         // Не удаляйте строки ниже
//         CompareNumbers(firstNumber, secondNumber);
//     }
// }

// Задача 2. Внутри класса Answer напишите метод FindMax, который принимает на вход три числа и выдаёт максимальное из этих чисел.

// using System;
// using System.ComponentModel.DataAnnotations;

// public class Answer {

//     static int FindMax (int a, int b, int c)
//     {
//       // Введите свое решение ниже

//      int max = a;

//       if (a < b)

//       max = b;
      
//       if (b < c)

//       max = c;

//       return max;
      


//     }

//   // Не удаляйте и не меняйте метод Main! 
//   static public void Main(string[] args) {
//         int a, b, c;

//         if (args.Length >= 3) {
//            a = int.Parse(args[0]);
//            b = int.Parse(args[1]);
//            c = int.Parse(args[2]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//            a = 9;
//            b = 6;
//            c = 1;
//         }

//         // Не удаляйте строки ниже
//         int result = FindMax(a, b, c);
//         System.Console.WriteLine($"{result}");
//     }
// }
// 

// Задача 3 Внутри класса Answer напишите метод CheckIfEven, 
// который на вход принимает число number и выводит, является ли число чётным (делится ли оно на два без остатка).
// using System;

// class Answer {
//     static void CheckIfEven(int number)
//     {
//       // Введите свое решение ниже
     
//       if  (number %2 == 0)
//       {
//         Console.Write("четное");
//       }
//       if  (number %2 == 1)
//       {
//         Console.Write("нечетное");
//       }
     
//     }
  

//   // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 3;
//         }

//         // Не удаляйте строки ниже
//         CheckIfEven(number);
//     }
// }

// Задача 4. Внутри класса Answer напишите метод PrintEvenNumbers, которая на вход принимает число (number), 
// а на выходе выводит все чётные числа от 1 до number (включительно), после каждого числа должен быть знак пробела.

// using System;

// public class Answer {
//     static void PrintEvenNumbers(int number)
//     {
//       // Введите свое решение ниже
//  int num = 1;
//  index = 0;
//       while (num <= number)
//     {
//         if (num %2 == 0)
//         {
//             Console.Write ($"{num} ");
//             index ++;
//         }
//         else 
//         {
//             num ++;
//         }
//     }

//     }


//   // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 6;
//         }

//         // Не удаляйте строки ниже
//         PrintEvenNumbers(number);
//     }
// }