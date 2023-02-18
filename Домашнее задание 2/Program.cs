// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Write("Введите пятизначное число : " );
// int num = int.Parse(Console.ReadLine()!);
// if(num / 10000 == num % 10 && num % 10000 / 1000 == num % 100 / 10)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }


// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Write("Введите координаты X1 : ");
// int X1 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите координаты Y1 : ");
// int Y1 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите координаты X2 : ");
// int X2 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите координаты Y2 : ");
// int Y2 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите координаты Z1 : ");
// int Z1 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите координаты Z2 : ");
// int Z2 = int.Parse(Console.ReadLine()!);
// int A = (X2 - X1) * (X2 - X1);
// int B = (Y2 - Y1) * (Y2 - Y1);
// int C = (Z2 - Z1) * (Z2 - Z1);
// double ABC = Math.Sqrt(A + B + C);
// Console.WriteLine(Math.Round(ABC, 2));

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число : ");
int N = int.Parse(Console.ReadLine()!);
int x = 1;
while(x <= N)
{
    int y = x*x*x;
    Console.WriteLine(y);
    x++;
}
