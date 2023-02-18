// Console.Write("Введите четверть: " );
// int X = int.Parse(Console.ReadLine()!);

// if(X == 1)
// {
//     Console.WriteLine("Диапазон х от 0 до 5 и диапазон y от 0 до 5");
// }
// if(X == 2)
// {
//     Console.WriteLine("Диапазон x от -5 до 0 и диапазн y от 0 до 5");
// }
// if(X == 3)
// {
//     Console.WriteLine("Диапазон x от -5 до 0 и диапазн y от -5 до 0");
// }
// if(X == 4)
// {
//     Console.WriteLine("Диапазон x от 0 до 5 и диапазн y от -5 до 0");
// }


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
//AB = √(xb - xa)2 + (yb - ya)2

// Console.Write("Введите координаты X1 : ");
// int X1 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите координаты Y1 : ");
// int Y1 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите координаты X2 : ");
// int X2 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите координаты Y2 : ");
// int Y2 = int.Parse(Console.ReadLine()!);
// int A = (X2 - X1)*(X2 - X1);
// int B = (Y2 - Y1)*(Y2 - Y1);
// double AB = Math.Sqrt(A + B);
// Console.Write(Math.Round (AB, 2));

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


Console.Write("Введите число : ");
int N = int.Parse(Console.ReadLine()!);
int x = 1;
while(x <= N)
{
    int y = x*x;
    Console.WriteLine(y);
    x++;
}