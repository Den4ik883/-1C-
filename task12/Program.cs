// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];
//     for(int i =0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue);
//     }
//     return res;
// }

// void ReverseArray1(int[] inArray)
// {
//     for( int i = 0; i < inArray.Length/2; i++)
//     {
//         int k = inArray[i];
//         inArray[i] = inArray[inArray.Length - 1 - i];
//         inArray[inArray.Length - 1 - i] = k;
//     }
// }

// int[] ReverseArray2(int[] inArray)
// {
//     int[] result = new int[inArray.Length];
//     for(int i = 0; i < inArray.Length; i++)
//     {
//         result[i] = inArray[inArray.Length - 1 - i];

//     }
//     return result;
// }


// int[] array = GetArray(10, 0, 10);
// Console.WriteLine(string.Join(",", array));
// //ReverseArray1(array);//изменение основного

// int[] revreseArray = ReverseArray2(array);// переворачивание массива без изменения основного
// Console.WriteLine(string.Join(",", revreseArray));
// Console.WriteLine(string.Join(",", array));


// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

// int GetTriangle(int x, int y, int c)
// {
//     int xy = x + y;
//     int yc = y + c;
//     int cx = c + x;
//     if(x < yc && y < cx && c < xy)
//     {
//         Console.WriteLine("Такой треугольник может существовать");
//     }
//     else Console.WriteLine("Такой треугольник не может существовать");
//     return x;
//     return y;
//     return c;
// }

// Console.WriteLine("Введите число : ");
// int num = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число : ");
// int num1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число : ");
// int num2 = int.Parse(Console.ReadLine()!);
// int res = GetTriangle(num, num1, num2);

// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Console.WriteLine("Введите число : ");
// int num = int.Parse(Console.ReadLine()!);

// int n = num;
// int ost = 0;
// string res = string.Empty;
// while(num > 0)
// {
//     ost = num % 2;
//     res = ost + res;
//     num = num / 2;
// }
// Console.WriteLine(res);

// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// int f(int n)
// {
//     if(n == 1 || n == 2) return 1;
//     else return f(n - 1) + f(n - 2);
// }
// for(int i = 1; i < 10; i++)
// {
//     Console.WriteLine(f(i));
// }
// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.