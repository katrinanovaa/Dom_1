/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее
арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m,n];
    for (int i=0; i<m; i++)
    {
        for (int j=0; j<n; j++)
        {
            result[i,j] = new Random().Next(0,20); 
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j=0; j< inArray.GetLength(1); j++)
        {
            Console.Write("{0,8:F2}", $"{inArray[i,j]}\t");
        }
        Console.WriteLine();
    }
}

double[] FindAverage(int[,] findArray)
{
    int sizeColumn = findArray.GetLength(1);
    double[] result = new double[sizeColumn];
    for (int i = 0; i < sizeColumn; i++)
    {
        double average = 0;
        for (int j = 0; j < findArray.GetLength(0); j++)
        {
            average += findArray[j,i];
        }
        result[i] = Math.Round(average/sizeColumn, 2);
    }
    return result;
}

Console.Clear();
Console.Write("Введите количество строк в матрице: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в матрице: ");
int col = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(row,col);
PrintArray(array);
Console.WriteLine("Cреднее арифметическое элементов в каждом столбце: ");
Console.Write(string.Join("; ", FindAverage(array)));