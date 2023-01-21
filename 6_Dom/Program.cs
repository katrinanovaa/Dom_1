/*Задача 13: Напишите программу, которая выводит
третью цифру заданного числа или сообщает, что третьей цифры нет.
(Цифры считать справа налево).
645 -> 6
78 -> третьей цифры нет
32679 -> 6*/

Console.Clear();
Console.WriteLine("Введите многозначное число:");
int n1 = int.Parse(Console.ReadLine()!);
double res = Math.Abs(n1/100);
if (res>0)
{
    res =res%10;
    Console.WriteLine($"{res}");
}
else
{
    Console.WriteLine("Третьей цифры не существует, увы(");
}