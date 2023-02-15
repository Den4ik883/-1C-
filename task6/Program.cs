Console.WriteLine("Введите число");
int x = int.Parse(Console.ReadLine()!);
int y = x % 7;
int c = x % 23;
if(y == 0 && c == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
