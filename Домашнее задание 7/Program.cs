// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine($"Введите число N >>>");
// int N = Convert.ToInt32(Console.ReadLine()!);
// Concequense(N);
// void Concequense(int n)
// {
//     if(n > 0)
//     {
//         Console.Write($"{n},");
//         Concequense(n - 1);
//     }
// }

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine($"Введите M >>>");
// int M = Convert.ToInt32(Console.ReadLine()!);
// Console.WriteLine($"Введите N >>>");
// int N = Convert.ToInt32(Console.ReadLine()!);
// int sum = 0;
// Console.Write($"{SumNum(M, N, sum)}");
// SumNum(M, N, sum);
// int SumNum(int m, int n, int sum)
// {
//     if(m > n) return sum;
//     else
//     {
//         sum = sum + m;
//         return SumNum(m + 1, n, sum);
//     }
// }
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine($"Введите M >>>");
int M = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine($"Введите N >>>");
int N = Convert.ToInt32(Console.ReadLine()!);
FunctionA(M, N);
Console.WriteLine($"{FunctionA(M,N)}");
int FunctionA(int m, int n )
{
    if(m == 0)
    {
       return n + 1 ; 
    } 
    if(m > 0 && n == 0)
    {
        return FunctionA(m - 1, 1);
    } 
    if(m > 0 && n > 0)
    {
       return FunctionA(m - 1, FunctionA(m , n - 1));
    }
    return FunctionA(m, n);
}