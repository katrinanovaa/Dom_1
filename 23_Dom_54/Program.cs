/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m,n];
    for (int i=0; i<m; i++)
    {
        for (int j=0; j<n; j++)
        {
            result[i,j] = new Random().Next(0,100); 
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

int[] GetSortedRow(int[] array)                     //сортировка одномерного массива методом пузырька
{
    for (int j = 0; j < array.Length; j++) 
    {
        for (int i = 0; i < array.Length - 1; i++) 
        {
            if (array[i] < array[i + 1]) 
            {
                int temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
            }
        }
    }
    return array;
}

int[,] GetSortedMatrix(int[,] matrix)
{
    int row = matrix.GetLength(0);
    int column = matrix.GetLength(1);
    int[,] sortedMatrix = new int[row, column];
    for (int m = 0; m < row; m++)
    {
        int[] rowArray = new int[column];
        //Получение строки массива в переменную rowArray
        for (int n = 0; n < column; n++)
        {
            rowArray[n] = matrix[m,n];
        }
        var sortedRow = GetSortedRow(rowArray); //Сортировка массива(строки)
        for (int n = 0; n < sortedRow.Length; n++)
        {
            sortedMatrix[m,n] = sortedRow[n]; //Записываем в массив отсортированную строку
        }
    }
    return sortedMatrix;
}

Console.Clear();
Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int col = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(row,col);
Console.WriteLine("Первоначальная матрица: ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Отсортированный массив:");
PrintArray(GetSortedMatrix(array)); //Сортруем массив и выводим отсортированный массив на печать