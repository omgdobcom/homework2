// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if ( number == 6 || number == 7)
{
    Console.WriteLine("Выходной день");
}
if (1 <= number && number <= 5)
{
    Console.WriteLine("Не выходной день");
}
if ( number > 7)
{
    Console.WriteLine("Цифра не является днём недели");
}