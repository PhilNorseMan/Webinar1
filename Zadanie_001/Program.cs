// Написать программу, которая принимает на вход два числа и проверяет, является ли первое число квадратом второго.
Console.WriteLine("Программа проверки квадрата числа");
Console.WriteLine("Введите первое число:");

string inputString_a = Console.ReadLine()!;
int input_a = int.Parse(inputString_a);

Console.WriteLine("Введите второе число:");

string inputString_b = Console.ReadLine()!;
int input_b = int.Parse(inputString_b);

if (input_a == input_b * input_b)
{
    Console.WriteLine("Да, первое число является квадратом второго");
}
else
{
    Console.WriteLine("Нет, первое число не является квадратом второго");

}