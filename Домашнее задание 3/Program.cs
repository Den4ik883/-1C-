// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[] GetArray()
// {
//     int size = 10;
//     int[] res = new int [size];
//     for(int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(100,999);
//     }
//     return res;
// }
// void PrintArray(int[] inArray)
// {
//     for(int i = 0; i < inArray.Length; i++)
//     {
//         Console.Write($" {inArray[i]} ");
        
//     }
// }
// void GetEvenNum(int[] inArray)
// {
//     int count = 0;
//     for(int i = 0; i < inArray.Length; i++)
//     {
//         if(inArray[i] % 2 == 0)
//         {
//             count++;
//         }
//     }
//     Console.Write(count);
// }
// int[] array = GetArray();
// PrintArray(array);
// GetEvenNum(array);


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int[] GetArray()
// {
//     int size = 10;
//     int[] res = new int [size];
//     for(int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(-9,10);
//     }
//     return res;
// }
// void PrintArray(int[] inArray)
// {
//     for(int i = 0; i < inArray.Length; i++)
//     {
//         Console.Write($" {inArray[i]} ");
        
//     }
// }
// void GetSumInd(int[] inArray)
// {
//     int i = 1;
//     int sum = 0;
//     while(i < inArray.Length)
//     {
//         sum = sum + inArray[i];
//         i = i + 2;
//     }
//     Console.WriteLine(sum);
// }
// int[] array = GetArray();
// PrintArray(array);
// Console.WriteLine("");
// GetSumInd(array);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// int[] GetArray()
// {
//     int size = 10;
//     int[] res = new int [size];
//     for(int i = 0; i < size; i++)
//     {
//         res[i] = new Random().NextDouble()*100;
//     }
//     return res;
// }
// void PrintArray(int[] inArray)
// {
//     for(int i = 0; i < inArray.Length; i++)
//     {
//         Console.Write($" {inArray[i]} ");
        
//     }
// }

// void GetDifferenceNum(int[] inArray)
// {
//     int max = 0;
//     int min = inArray[0];
//     for(int i = 0; i < inArray.Length; i++)
//     {
//         if(inArray[i] > max)
//         {
//             max = inArray[i];
//         }
//         else if(inArray[i] < min)
//         {
//             min = inArray[i];
//         }
//     }
//     int sum = min - max;
//     Console.WriteLine(sum);
// }
// int[] array = GetArray();
// PrintArray(array);
// GetDifferenceNum(array);


int[] GetArray()
{
    int size = 10;
    int[] res = new int [size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(1, 99);
    }
    return res;
}
void PrintArray(int[] inArray)
{
    for(int i = 0; i < inArray.Length; i++)
    {
        Console.Write($" {inArray[i]} ");
        
    }
}

void GetDifferenceNum(int[] inArray)
{
    int max = 0;
    int min = inArray[0];
    for(int i = 0; i < inArray.Length; i++)
    {
        if(inArray[i] > max)
        {
            max = inArray[i];
        }
        else if(inArray[i] < min)
        {
            min = inArray[i];
        }
    }
    int sum = max - min;
    Console.WriteLine(sum);
}
int[] array = GetArray();
PrintArray(array);
GetDifferenceNum(array);