/*Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int[] GetArray(int size)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(100,999);       
        Console.WriteLine($"{res[i]}, ");
    }
    return res;
}

int Sum(int[] result)
{
    int count = 0;
    for(int i = 0; i < result.Length; i++)
    {
        int ostatok = 0;
        ostatok = result[i]%2;
        if(ostatok==0)
        {
            count++;          
        }
    }
    return count;
}

Console.Clear();
Console.WriteLine("Введите длину вашего массива: ");
int dlina = int.Parse(Console.ReadLine()!);
Console.WriteLine("Рандомные числа массива, выданные программой: ");
int[] array = GetArray(dlina);
Console.Write("Сгенерированный массив: ");
Console.WriteLine(String.Join(", ", array));
Console.Write("Количество четных чисел в массиве: ");
int sum = Sum(array);
Console.Write(sum);
