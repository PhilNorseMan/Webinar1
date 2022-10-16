// Программа, которая на вход принимает число N, на выходе выводит диапазон чисел от -N до N.
Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()!);
int number_minus = number * (-1);

if (number < 0)
{
    int temp = number;
    number = number_minus;
    number_minus = temp;
}

while (number_minus <= number)
{
    Console.Write(number_minus + " ");
    number_minus++;
}
