/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m,n];
    for (int i=0; i<m; i++)
    {
        for (int j=0; j<n; j++)
        {
            result[i,j] = new Random().Next(0,10); 
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
            Console.Write("{0,8:F2}", $"{inArray[i,j]}\t "); 
        }
        Console.WriteLine();
    }
}

(int row, int sum) GetMinSumRow(int[,] matrix)
{
    int sum = GetSumRow(matrix, 0);
    var result = (1, sum);
    for (int m = 1; m < matrix.GetLength(0); m++)
    {
        int nextSum = GetSumRow(matrix, m);
        if(sum > nextSum)
        {
            sum = nextSum;
            result = (m + 1,sum);
        }
    }
    return result;
}

int GetSumRow(int[,] matrix, int m)
{
    int sum = 0;
    for (int n = 0; n < matrix.GetLength(1); n++)
    {
        sum += matrix[m, n];
    }
    return sum;
}
Console.Clear();
Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int col = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(row,col);
Console.WriteLine("Первоначальная матрица: ");
PrintArray(array);
var minSumRow = GetMinSumRow(array);
Console.WriteLine($"Минимальная сумма {minSumRow.Item2} в строке {minSumRow.Item1}");