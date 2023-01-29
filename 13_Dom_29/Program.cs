/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int[] GetArray(int size)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(-20,20);       
        Console.WriteLine($"{res[i]}, ");
    }
    return res;
}

Console.Clear();
Console.WriteLine("Введите длину вашего массива: ");
int dlina = int.Parse(Console.ReadLine()!);
Console.WriteLine("Рандомные числа массива, выданные программой: ");
int[] array = GetArray(dlina);
Console.Write("Сгенерированный массив: ");
Console.WriteLine(String.Join(", ", array));