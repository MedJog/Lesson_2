// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

if (a < 1 || a > 7) 
{
    Console.WriteLine("Введите другое число.");
}
if (a > 0 && a < 6) 
{
    Console.WriteLine("Этот день не является выходным.");
} 

if ( a == 6 || a == 7) 
{
Console.WriteLine("Да, это выходной день!");
}
