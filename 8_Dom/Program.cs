/*Задача 19
Напишите программу, которая принимает на вход 
пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.Clear();
Console.WriteLine("Введите пятизначное число");
int n1 = int.Parse(Console.ReadLine()!);
n1=Math.Abs(n1);
int x1 = n1/10000; //Console.WriteLine($"Число {x1}");
int x2 = n1/1000%10; //Console.WriteLine($"Число {x2}");
int x4 = n1%100/10; //Console.WriteLine($"Число {x4}");
int x5 = n1%10; //Console.WriteLine($"Число {x5}");
if ((x1==x5)&&(x2==x4))
{
    Console.WriteLine($"Число {n1} палиндром");
}
else Console.WriteLine($"Число {n1} не палиндром");