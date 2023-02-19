/*Задача 60. ...Сформируйте трёхмерный массив из 
неповторяющихся двузначных чисел. Напишите программу, которая будет построчно 
выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int[,,] Create3DMatrix(int m, int n, int k, int min, int max)
{
    int[,,] matrix = new int[m, n, k];
    var dictionary = new Dictionary<int, (int, int, int)>();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int d = 0; d< matrix.GetLength(2); d++)
            {
                int newElement;
                newElement = new Random().Next(min, max);
                while(dictionary.ContainsKey(newElement))
                {
                    newElement = new Random().Next(min, max);
                }
                dictionary[newElement] = (i, j, d);
                matrix[i, j, d] = newElement;
            }
        }
    }
    return matrix;
}

void PrintMatrix3(int[,,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i,j,k]}({i},{j},{k}) ");
            }
            Console.Write("\n");

        }
    }
}

Console.Clear();
Console.WriteLine("Трехмерная матрица: ");
int[,,] matrix3D = Create3DMatrix(2, 2, 2, 1, 100);
PrintMatrix3(matrix3D);