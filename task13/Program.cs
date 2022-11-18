// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number > 1000)
{
    number = number / 10;
}

if ( number < 100)
{
    Console.WriteLine("В числе меньше трёх цифр");
}

if (number > 99 && number < 1000 )
{
    int numThird = number % 10;
    Console.WriteLine($"Третья цифра введенного числа: {numThird}");
}
