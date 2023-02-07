/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/


double[,] GetArray(int m, int n)
{
    double[,] result = new double[m,n];
    for (int i=0; i<m; i++)
    {
        for (int j=0; j<n; j++)
        {
            result[i,j] = Math.Round(new Random().NextDouble(), 2)- new Random().Next(-100,100); 
        }
    }
    return result;
}
void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j=0; j< inArray.GetLength(1); j++)
        {
            Console.Write("{0,8:F2}", $"{inArray[i,j]}\t ");   // {0,8:F2} - взято из чата, надо разбраться, как это работает
        }
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("введите количество столбцов: ");
int col = int.Parse(Console.ReadLine()!);

double[,] array = GetArray(row,col);
PrintArray(array);