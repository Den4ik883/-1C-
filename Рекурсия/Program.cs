
// Console.WriteLine($"\nВведите размер массива m x n и диапазон случайных значений:");
// int m = InputNumbers("Введите m: ");
// int n = InputNumbers("Введите n: ");
// int range = InputNumbers("Введите диапазон: от 1 до ");

// int[,] array = new int[m, n];
// CreateArray(array);
// WriteArray(array);

// int minSumLine = 0;
// int sumLine = SumLineElements(array, 0);
// for (int i = 1; i < array.GetLength(0); i++)
// {
//   int tempSumLine = SumLineElements(array, i);
//   if (sumLine > tempSumLine)
//   {
//     sumLine = tempSumLine;
//     minSumLine = i;
//   }
// }

// Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");


// int SumLineElements(int[,] array, int i)
// {
//   int sumLine = array[i,0];
//   for (int j = 1; j < array.GetLength(1); j++)
//   {
//     sumLine += array[i,j];
//   }
//   return sumLine;
// }

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(range);
//     }
//   }
// }

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//   }
// }


// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// int GetNum(int N)
// {
//     int firstNum = 1;
//     while(firstNum <= N)
//     {
//         Console.Write($"{firstNum},");
//         firstNum = firstNum + 1;
//     }
//     return firstNum;
// }

// void Concequense(int num, int start)
// {
//     if(start <= num)
//     {
//         Console.Write($"{start},");
//         Concequense(num, start + 1);
//     }
    
// }
// Console.WriteLine($"Введите число N =>>> ");
// int num = Convert.ToInt32(Console.ReadLine()!);
// int start = 1;
// Concequense(num, start);
// //GetNum(num);


// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

// Console.WriteLine($"Введите число M >>>");
// int M = Convert.ToInt32(Console.ReadLine()!);
// Console.WriteLine($"Введите число N >>>");
// int N = Convert.ToInt32(Console.ReadLine()!);
// Concequense(M, N);

// void Concequense(int numOne, int numTwo)
// {
//     if(numOne <= numTwo)
//     {
//         Console.Write($"{numOne}, ");
//         Concequense(numOne + 1, numTwo);
//     }
// }

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// Console.WriteLine($"Введите число >>>");
// int num = Convert.ToInt32(Console.ReadLine()!);
// int sum = 0;
// SumNumber(num, sum);
// int SumNumber(int num, int sum)
// {
//     if(num == 0) return sum;
//     else
//     {
//         sum += num % 10;
//         return SumNumber(num/10, sum);
//     }
// }
// Console.Write($"{SumNumber(num,sum)}");
// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine($"Введите число >>>");
int A = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine($"Введите Степень >>>");
int B = Convert.ToInt32(Console.ReadLine()!);
int sum = 1;
DegreeA(A, B, sum);
Console.WriteLine($"{DegreeA(A, B, sum)}");

int DegreeA(int num, int degr, int sum)
{
    if(degr == 0) return sum;
    else
    {
         sum = sum * num;
        return DegreeA(num, degr -1, sum);
    }
       
}