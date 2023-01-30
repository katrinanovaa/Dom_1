/*Задача 36: Задайте одномерный массив, заполненный
 случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] GetArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(-999,999);       
        //Console.WriteLine($"{res[i]}, ");        //Если хотим увидеть, какие числа были сгенерированы
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
        if(ostatok!=0)
        {
            count+=result[i];          
        }
    }
    return count;
}

Console.Clear();
Console.WriteLine("Введите длину вашего массива: ");
int dlina = int.Parse(Console.ReadLine()!);
//Console.WriteLine("Рандомные числа массива, выданные программой: ");
int[] array = GetArray(dlina);
Console.Write("Сгенерированный массив: ");
Console.WriteLine(String.Join(", ", array));
Console.Write("Сумма нечетных чисел в массиве: ");
int sum = Sum(array);
Console.Write(sum);

