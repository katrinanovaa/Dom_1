/*Задача 25: Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Нельзя использовать библиотеку Math!
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

double Result(double A, double B)
{
    double resultat =1;
    if (B>=0)
    {
        for (int i=1; i <= B;)
        {
            resultat*=A;
            i++;
        }
    }
    else
    {
        B*=-1;
        for (int i=1; i <= B;)
        {
            resultat*=1/A;
            i++;
        };
    }
    return (resultat);
}
Console.Clear();
Console.WriteLine("Введите число А");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine(Math.Round(Result(a, b), 6));