/*Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

Console.Clear();
Console.WriteLine("Программа, которая выведет все натуральные числа в промежутке от N до 1");
Console.WriteLine("Введите N");
int number = int.Parse(Console.ReadLine()!);
Console.Write($"N={number}-> ");
PrintNumber(number);
void PrintNumber(int i)
{
    if (i == 1)
    {
        Console.WriteLine(i);
        return;
    }
    Console.Write($"{i}, ");
    i--;
    PrintNumber(i);
}