// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
int i = 0;
int j = 0;
int b = a;
if (a < 100 && a > -100) 
{
    Console.WriteLine("Третьей цифры нет");
}
else 
{
while (b >= 1)
{
    b = b / 10;
    i++;
}
Console.WriteLine(i);
}
while (j < i-3)
{
    a = a / 10;
  //  Console.WriteLine(a);
    j++;
}
a = a % 10;

 Console.WriteLine(a); 
