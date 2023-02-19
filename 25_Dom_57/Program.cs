/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

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

int[,] GetMultiplicationMatrix(int[,] matrixA, int[,] matrixB)
{
    int rowA = matrixA.GetLength(0);
    int columnA = matrixA.GetLength(1);
    int rowB = matrixB.GetLength(0);
    int columnB = matrixB.GetLength(1);
 
    int[,] matrixResult = new int[rowA, columnB];

    if(columnA != rowB)
    {
        return null;
    }

    for(int mA = 0; mA < rowA; mA++)
    {
        for(int nB = 0; nB < columnB; nB++)
        {
            int sum = 0;
            for(int mB = 0; mB < rowB; mB++)
            {
                sum += matrixA[mA, mB] * matrixB[mB, nB];   
            }
            matrixResult[mA, nB] = sum;
        }
    }
    return matrixResult;
}

Console.Clear();
Console.Write("Введите количество строк первой матрицы: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов первой матрицы: ");
int col = int.Parse(Console.ReadLine()!);

int[,] array1 = GetArray(row,col);
Console.WriteLine("Первоначальная матрица: ");
PrintArray(array1);
Console.Write("Поскольку для произведения матриц должно выполняться условие, что \nколичество столбцов первой матрицы должно быть равно количеству строк второй матрицы, то остается ввести только\nКоличество столбцов второй матрицы: ");
int col2 = int.Parse(Console.ReadLine()!);
int[,] array2 = GetArray(col,col2);
PrintArray(array2);

Console.WriteLine("Массив полученный в результате произведения матрицы А на матрицу В:");
PrintArray(GetMultiplicationMatrix(array1, array2));
