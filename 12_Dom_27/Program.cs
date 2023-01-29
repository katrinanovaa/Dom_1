/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/


int GetSum(int number)
{
    int summa = 0;
    int ostatok = 0;
    while (number>0)
    {
        ostatok = number % 10;
        number = number / 10;
        summa += ostatok;
    }
    return summa;
}
Console.Clear();
Console.WriteLine("Введите число: ");
int numb = int.Parse(Console.ReadLine()!);
if (numb<0) numb*=-1;


Console.WriteLine(GetSum(numb));
