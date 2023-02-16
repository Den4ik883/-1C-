// Console.Write("Ввeдите число 1:" );
// int x = int.Parse(Console.ReadLine()!);
// Console.Write("Ввeдите число 2:" );
// int y = int.Parse(Console.ReadLine()!);
// if (x == y*y || y == x*x){
//     Console.WriteLine("да");
// }
// else
// {
//     Console.WriteLine("нет");
// }


Console.Write("Введите число -");
int num = int.Parse(Console.ReadLine()!);
while(num > 999)
{
    num = num / 10;
}
if(num > 99 && num < 1000)
{
    int num2 = num % 10;
    Console.WriteLine(num2);
}
if(num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}