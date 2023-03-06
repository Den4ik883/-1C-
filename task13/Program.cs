
// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m,n];
//     for(int i = 0; i < m; i++)
//     {
//         for(int j = 0; j < n; j++)
//         {
//             result[i,j] = i + j;
//             Console.Write($"{result[i,j]} ");
//         }
//         Console.WriteLine();
//     }
//     return result;
// }
// Console.Write("Введите количество строк массива: ");
// int rows =int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество строк массива: ");
// int columns =int.Parse(Console.ReadLine()!);
// int[,] array = GetArray(rows,columns, 0, 10);
int[,] GetArray(int rows, int columns)
{
    int[,] res = new int [rows,columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            res[i,j] = new Random().Next(1,9);
        }
    }
    return res;
}
void PrintArray(int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++) 
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();   
    }
}
void GetSumInd(int[,] inArray)
{
    int sum = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if(i == j)
            {
                sum = sum + inArray[i,j];
            }
        }        
    }
    Console.WriteLine($"Сумма элементов диагонали равна: {sum}");
}
Console.Write("Введите количество строк массива: ");
int rows =int.Parse(Console.ReadLine()!);
Console.Write("Введите количество строк массива: ");
int columns =int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows,columns);
PrintArray(array);
Console.WriteLine();
GetSumInd(array);
//PrintArray(array, rows, columns);


// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

