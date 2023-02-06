/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

int[,] GetArray( int m, int n)
{
    int[,] result = new int[m,n];
    for (int i=0; i<m; i++)
    {
        for (int j=0; j<n; j++)
        {
            result[i,j] = new Random().Next(-100,100); 
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

void FindPosition(int[,] inArray, int num1, int num2)
{

    if(num1>inArray.GetLength(0) || num2>inArray.GetLength(1))

{

    Console.WriteLine("Такой позиции не существует");
}
    int a = inArray[num1-1,num2-1];
    Console.WriteLine(a);
    // for(int i = 0; i < inArray.GetLength(0); i++) 
    // {
    //     for (int j = 0; j < inArray.GetLength(1); j++)
    //     {
    //         if ((i==num1-1)&&(j==num2-1))
    //         {
    //             Console.WriteLine($"{inArray[i,j]} - данное число");
    //         }
    //         else 
    //         {
    //         }
    //     }
    // }
}

Console.Clear();
Console.Write("введите количество строк в матрице: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("введите количество столбцов в матрице: ");
int col = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(row,col);
PrintArray(array);

Console.Write("введите i индекс желаемого числа: ");
int rowIndex = int.Parse(Console.ReadLine()!);
Console.Write("введите j индекс желаемого числа: ");
int colIndex = int.Parse(Console.ReadLine()!);
FindPosition(array, rowIndex, colIndex);

