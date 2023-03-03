
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// double[] GetArray(double size)
// {
//     double[] Array = new double[size];
//     for(double i = 0; i < size; i++)
//     {
//     Console.WriteLine("Введите число");
//     Array[i] = Convert.Todouble32(Console.ReadLine()!);
//     }
//     return Array
// ;
// }

// void PrdoubleArray(double[] Array)
// {
//     for(double i = 0; i < Array.Length; i++)
//     {
//         Console.Write($"{Array[i] },");
//     }
// }

// void GetQuantityNum(double[] Array)
// {
//     double count = 0;
//     double i = 0;
//     while(i < Array.Length)
//     {
//         if(Array[i] > 0)
//         {
//             count++;
//         }
//         i++;
//     }
//     Console.WriteLine($"= {count}");
// }
// Console.WriteLine("Введите количество чисел которые собираетесь ввести :");
// double num = Convert.Todouble32(Console.ReadLine()!);
// double[] array = GetArray(num);
// PrdoubleArray(array);
// GetQuantityNum(array);

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
 
 
double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");