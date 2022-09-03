// Задача 63: Задайте значение N. 
// Напишите программу, которая выведет 
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// int N = Convert.ToInt32(Console.ReadLine());
// //start - 1 (начало)
// // end - N - конец последовательности 
// string PrintNumbers(int start, int end)
// {
//     //БАзовый случай
//     if (start == end) return start.ToString();
//     //Рекурсивный случай
//     return (start + ", " + PrintNumbers(start + 1, end));
// }
// Console.WriteLine($"Числа от 1 до {N}:  [{PrintNumbers(1, N)}] ");

// Задача 65: Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

// int M =Convert.ToInt32(Console.ReadLine());
// int N = Convert.ToInt32(Console.ReadLine());
// // start = 1, откуда начинаем печать чисел; end - N, конец нашей последовательности
// string PrintNumbers(int start, int end)
// {
//     // Базовый случай
//     if (start == end) return start.ToString(); // N = 5; start == 5, "5"
//     // Рекурсивный случай
//     return (start + ", " + PrintNumbers(start + 1, end));
// }
// Console.WriteLine($"Числа от {M} до {N}: [{PrintNumbers(M, N)}]");

// Задача 67: Напишите программу, которая будет принимать на вход число 
//и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
// int number = Convert.ToInt32(Console.ReadLine());
// int SumNumbers(int num)
// {
//     //базовый
//     if(num==0) return 0; //sum + 0 = sum
//     //рекурсивный случай
//     return(num % 10 + SumNumbers(num / 10));
// }

// Console.WriteLine($"Сумма цифр в числе {number} равна {SumNumbers(number)}");

// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// int number = Convert.ToInt32(Console.ReadLine());
// int degree = Convert.ToInt32(Console.ReadLine());
// int Power(int number,int power)
// {
//     //Базовый случай- случаи с заранее известным результатом
//     if(power==0) return 1;
//     if(power==1) return number;
//     //Рекурсивный случай
//     return(number * Power(number, power-1));
// }
// Console.WriteLine($"Число {number} в степени {degree} равно {Power(number, degree)}");


