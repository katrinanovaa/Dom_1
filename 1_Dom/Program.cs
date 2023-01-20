/* Семинар 1. Задача №1(2).
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.WriteLine("Напиши первое целочисленное число:");
int n1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Напиши второе целочисленное число:");
int n2 = int.Parse(Console.ReadLine()!);
int max = n1;
if (n1<n2) max = n2;
{
    Console.WriteLine($"Максимальное число {max}");
}
   
