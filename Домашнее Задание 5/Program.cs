// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// double[,] GetArray(int m, int n)
// {
//     double[,] result = new double[m,n];
//     for(int i = 0; i < m; i++)
//     {
//         for(int j = 0; j < n; j++)
//         {
//             result[i,j] = new Random().NextDouble();
//             Console.Write($"{Math.Round(result[i,j], 2)} ");
//         }
//         Console.WriteLine();
//     }
//     return result;
// }
// Console.Write("Введите количество строк массива: ");
// int rows =int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество строк массива: ");
// int columns =int.Parse(Console.ReadLine()!);
// double[,] array = GetArray(rows,columns);




// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// [1,7] -> по данным индексам такого числа в массиве нет


// int[,] GetArray(int rows, int col)
// {
//     int[,] res = new int[rows, col];
//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < col; j++)
//         {
//             res[i,j] = new Random().Next(1, 9);
//         }
//     }
//     return res;
// }

// void PrintArray(int[,] res)
// {
//     for (int i = 0; i < res.GetLength(0); i++)
//     {
//         for (int j = 0; j < res.GetLength(1); j++)
//         {
//             Console.Write($"{res[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void IndexSearch(int[,] res)
// {
//     Console.WriteLine($"Введите индекс строки: ");
//     int indexOne = Convert.ToInt32(Console.ReadLine()!);
//     Console.WriteLine($"Введите индекс столбца: ");
//     int indexTwo = Convert.ToInt32(Console.ReadLine()!);
//     if(indexOne > res.GetLength(0) || indexTwo > res.GetLength(1))
//     {
//         Console.WriteLine($"[{indexOne},{indexTwo}] - по таким координатом числа нет в массиве");
        
//     }
//     else
//     {
//         Console.WriteLine($"{res[indexOne, indexTwo]} - число по заданым координатам");
//     }
// }
// Console.WriteLine($"Введите колличество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine()!);
// Console.WriteLine($"Введите колличество строк массива: ");
// int columns = Convert.ToInt32(Console.ReadLine()!);
// int[,] array = GetArray(rows,columns);
// PrintArray(array);
// IndexSearch(array);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetArray(int rows, int col)
{
    int[,] res = new int[rows, col];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < col; j++)
        {
            res[i,j] = new Random().Next(1, 9);
        }
    }
    return res;
}

void PrintArray(int[,] res)
{
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            Console.Write($"{res[i,j]} ");
        }
        Console.WriteLine();
    }
}
void AverageIndex(int[,] res)
{
    double average = 0;
    double sum = 0;
    for(int col = 0; col < res.GetLength(1); col++)
    {
        for(int rows = 0; rows < res.GetLength(0); rows++)
        {
            sum = sum + res[rows,col];
        }
        average = sum / res.GetLength(0);
        Console.Write($"{Math.Round(average,2)} ;");
    }
}
Console.WriteLine($"Введите колличество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine($"Введите колличество строк массива: ");
int columns = Convert.ToInt32(Console.ReadLine()!);
int[,] array = GetArray(rows,columns);
PrintArray(array);
Console.WriteLine();
AverageIndex(array);