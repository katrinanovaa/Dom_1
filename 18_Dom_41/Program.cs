/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

using System.Text;     // используем using для работы со строками

int GetCountNumbers(string[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(int.Parse(array[i]) > 0)
        {
            count++;
        }
    }
    return count;

}
Console.Clear();
Console.WriteLine("Введите числа через пробел или запятую");

StringBuilder readNumbers = new StringBuilder(Console.ReadLine());
string[] array = readNumbers.Replace(",", " ").ToString().Split(" ",StringSplitOptions.RemoveEmptyEntries);   //заменяем "," на пробелы, а потом пробелы являются разделителями в строке
Console.WriteLine(string.Join(", ",array));

Console.WriteLine("Число положительных чисел = " + GetCountNumbers(array));


