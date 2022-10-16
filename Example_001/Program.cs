// 1. Ввод числа
Console.WriteLine("Программа вычисления квадрата числа");
Console.WriteLine("Введите число:");

string inputString = Console.ReadLine()!;
int input = int.Parse(inputString);
// 2. Возвести число в квадрат
int result = input * input;
//3. Вывод результата на консоль
Console.WriteLine("Квардрат числа равен " + result);