//  Написать программу, которая будет выводить день недели в зависимоcти от его номера.

Console.WriteLine("Программа вывода дня недели");
Console.WriteLine("Введите номер дня недели:");

string inputString = Console.ReadLine()!;
int input = int.Parse(inputString);

if (input == 1)
{
    Console.WriteLine("Понедельник");
}
if (input == 2)
{
    Console.WriteLine("Вторник");
}
if (input == 3)
{
    Console.WriteLine("Среда");
}
if (input == 4)
{
    Console.WriteLine("Четверг");
}
if (input == 5)
{
    Console.WriteLine("Пятница");
}
if (input == 6)
{
    Console.WriteLine("Суббота");
}
if (input == 7)
{
    Console.WriteLine("Воскресенье");
}