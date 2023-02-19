/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.Clear();
Console.WriteLine("Программа, которая выведет все натуральные числа в промежутке от M до N");
Console.WriteLine("Введите M");
int numberM = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите N");
int numberN = int.Parse(Console.ReadLine()!);
Console.WriteLine(Sum(numberM, numberN));

int Sum(int m, int n)
{
    if (n <= m)
        return n;
    return n + Sum(m, n - 1);
}
