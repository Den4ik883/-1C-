
int number = new Random().Next(10,100);
int a1 = number / 10;
int a2 = number % 10;
if(a1 > a2)
{
    Console.WriteLine("Первая цифра в числе ="+ number + " наибольшая " + a1 );
}
else
{
Console.WriteLine("Вторая цифра в числе больше = "+ number + " наибольшая " + a2 );
}
