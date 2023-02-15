int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int a1 = number / 100;
int a2 = number % 10;
Console.Write(a1 * 10 + a2);
//Console.Write(a2);

