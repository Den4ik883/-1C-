//Console.Write("Введите число: ");
//int number =int.Parse( Console.ReadLine()!);
//int sqr = number * number;
//Console.WriteLine("Квадрат числа" + number + "равен = " + sqr);


//Console.Write("Ввeдите число 1:" );
//int x = int.Parse(Console.ReadLine()!);
//Console.Write("Ввeдите число 2:" );
//int y = int.Parse(Console.ReadLine()!);
//int sqr = x*x;
//if (sqr == y){
//    Console.WriteLine("да");
//}
//else
//{
//    Console.WriteLine("нет");
//}

//Console.Write("Введите число");
//int number = int.Parse(Console.ReadLine());



//if(number == 1){
//    Console.WriteLine("Понидельник");
//}
//if(number == 2){
//    Console.WriteLine("Вторник");
//}
//if(number == 3){
//    Console.WriteLine("Среда");
//}
//if(number == 4){
//    Console.WriteLine("Четверг");
//}
//if(number == 5){
//    Console.WriteLine("Пятница");
//}

Console.Write("Введите число");
int number = int.Parse(Console.ReadLine()!);
for(int i = - number; i <= number; i++){
    System.Console.WriteLine(i);
}