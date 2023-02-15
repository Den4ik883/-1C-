Console.WriteLine("Введите первое число");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе числол");
int y = int.Parse(Console.ReadLine()!);
int c = x % y;
if(c == 0)
{
    Console.WriteLine(x +  "Явлется кратным" + y);
}
else
{
    Console.WriteLine(x + "Не является кратным" + y);
}



