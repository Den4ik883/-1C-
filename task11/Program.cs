
// int[] GetArray()
// {
//     int size = 12;
//     int[] res = new int [size];
//     for(int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(-9,9);
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

// int[] array = GetArray();
// PrintArray(array);

// int positiveSum = 0;
// int negativeSum = 0;

// foreach(int el in array)
// {
//     if(el > 0)
//     {
//         positiveSum += el;
//     }
//     else
//     {
//         negativeSum += el;
//     }
// }
// Console.WriteLine();
// Console.WriteLine($"Сумма положительных чисел = {positiveSum} Сумма негативных чисел = {negativeSum}");

// адача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] GetArray()
// {
//     int size = 12;
//     int[] res = new int [size];
//     for(int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(-9,9);
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

// void IndMirror(int[] arr)
// {
//     for(int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = arr[i] * -1;
//     }   
// }
// int[] array = GetArray();
// PrintArray(array);
// IndMirror(array);
// Console.WriteLine("");
// PrintArray(array);



// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// int[] GetArray()
// {
//     int size = 15;
//     int[] res = new int [size];
//     for(int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(0,20);
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
// void GetNum(int[] inArray, int num)
// {
//     int count = 0;
//     for(int i = 0; i < inArray.Length; i++)
//     {
//         if(inArray[i] == num)
//         {
//             count++;
//         }
//     }
//     if(count > 0)
//     {
//         Console.Write("Да");
//     }
//     else
//     {
//         Console.Write("Нет");
//     }
    
// }

// Console.WriteLine("Задайте число: ");
// int num = int.Parse(Console.ReadLine()!);
// int[] array = GetArray();
// PrintArray(array);
// GetNum(array,num);

// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int[] GetArray()
// {
//     int size = 123;
//     int[] res = new int [size];
//     for(int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(0,500);
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
// void GetInd(int[] inArray)
// {
//     int sumindx = 0;
//     for(int i = 0; i < inArray.Length; i++)
//     {
//         if(inArray[i] >= 10 && inArray[i] <= 100)
//         {
//             sumindx++;
//         }
        
        
//     }
//     Console.Write( sumindx );
// }
// int[] array = GetArray();
// PrintArray(array);
// Console.WriteLine("");
// GetInd(array);



// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] GetArray()
{
    int size = 10;
    int[] res = new int [size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(1,15);
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
int[] GetSumInd(int[] inArray)
{
    int[] result = new int[inArray.Length / 2];
    for(int i = 0; i < inArray.Length / 2; i++)
    {
        result[i] = inArray[i] + inArray[inArray.Length - 1 -i ];
          
    }
    return result;
}

int[] array = GetArray();
PrintArray(array);
Console.WriteLine("");
int[] newArray = GetSumInd(array);
PrintArray(newArray);
