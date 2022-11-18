﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (99 < number && number < 1000)
{
    int result = number / 10 % 10;
    Console.WriteLine($"Вторая цифра: {result}");
}
else
{
    Console.WriteLine("Не трехзначное число");
}