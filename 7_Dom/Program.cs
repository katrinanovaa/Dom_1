/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.Clear();
Console.WriteLine("Введите цифру, обозначающую день недели");
int n1 = int.Parse(Console.ReadLine()!);
switch(n1)
{
    case 1: case 2: case 3: case 4: case 5: 
    {
        Console.WriteLine("Будний день"); 
        break;
    }
    case 6: case 7: 
    {
        Console.WriteLine("Выходной день"); 
        break;
    }
    default:
    {
        Console.WriteLine("Такого дня не существует, увы"); 
        break;
    }
}
