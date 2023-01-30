/*Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

double[] GetArray(int size)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = Math.Round(new Random().NextDouble(), 3)+ new Random().Next(-1000,1000); 
    }
    return res;
}

double Razn(double[] resultat)
{
    double MinValue = resultat[0];
    double MaxValue = resultat[0];
    for (int i=0; i < resultat.Length; i++)
    {
        if (resultat[i]> MaxValue) MaxValue=resultat[i];
        else
        {
            if (resultat[i]< MinValue)
            MinValue = resultat[i];
        }
    }
    double raznica = Math.Round(MaxValue - MinValue, 3);
    return raznica;
}

Console.Clear();
Console.WriteLine("Введите длину желаемого массива: ");
int dlina = int.Parse(Console.ReadLine()!);
double[] array = GetArray(dlina);
Console.Write("Сгенерированный массив: ");
Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"Разница между максимальным и минимальным элементами равна: {Razn(array)} ");
