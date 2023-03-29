// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.WriteLine("Введите трёхзначное число: ");
int a = int.Parse(Console.ReadLine()); // Находим вторую цифру заданного числа
int result = a / 10 % 10;
Console.WriteLine(result);

