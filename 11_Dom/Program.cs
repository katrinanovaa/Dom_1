/*Задача 25: Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Нельзя использовать библиотеку Math!
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

    Console.Clear();
    Console.WriteLine("Введите число А");
    int a = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите число B");
    int b = int.Parse(Console.ReadLine()!);
int Result(int result)
{
    //if (b<0) b=b*(-1);
    int resultat =1;
    for (int i=0; i <= b;)
    {
        resultat*=a;
        Console.WriteLine($"{resultat}");
        i++;
    }
    return (resultat);
}
Result(result);
Console.WriteLine(Result(result));

/*double raiseToPow(double x, int power)
{
    double result;
    int i;
    result =1.0;
    for (i=1, i<=power;i++)
    {
        result = result*x;
    }
    return(result);
}*/