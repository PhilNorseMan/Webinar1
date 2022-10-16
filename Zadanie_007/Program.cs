// Вывести последнюю цифру вводимого числа

Console.WriteLine("Введите число");

int number = int.Parse(Console.ReadLine()!);

Console.WriteLine("Последняя цифра - " + number%10);