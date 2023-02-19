/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

int[,] SpiralMatrix(int columnLength, int rowLength, int min, int max)
{
    int[,] matrix = new int[columnLength, rowLength];
    int m = 0;
    int dm = 0;
    int mEnd = matrix.GetLength(0);
    int n = 0;
    int dn = 1;
    int nEnd = matrix.GetLength(1);
    //Console.WriteLine("Координаты заполнения матрицы:");
    for (int i = 1; i <= columnLength * rowLength; i++)
    {
        int coner;
        //Console.WriteLine($"m= {m}, n= {n}");
        matrix[m,n] = i;
        if(Math.Abs(dn) == 1)
        {
            coner = n + dn;
        } else 
        {
            coner = m + dm;
        }
        if(coner < 0 || (dn == 1 && coner == nEnd) || (dm == 1 && coner == mEnd) || matrix[m + dm,n + dn] != 0)
        {
            int oldDn = dn;
            dn = dm * -1;
            dm = oldDn;
        }
        m += dm;
        n += dn;
    }
    return matrix;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j=0; j< inArray.GetLength(1); j++)
        {
            if (inArray[i,j]<10)
            {
                Console.Write("{0,4:F2}", $"0{inArray[i,j]}\t ");
            }
            else
            {
            Console.Write("{0,4:F2}", $"{inArray[i,j]}\t "); 
            }
        }
        Console.WriteLine();
    }
}

Console.Clear();
int[,] matrixSpiral = SpiralMatrix(4,4,0,50);
Console.WriteLine("Массив, заполненный по спирали:");
PrintArray(matrixSpiral);