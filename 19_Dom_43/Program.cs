/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
________________________________________*/

Console.Clear();
Console.WriteLine("Программа, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2\n");     // \n позволяет пропустить строку после данного сообщения

double k1 = ReadNumber("Введите значение k1");
double b1 = ReadNumber("Введите значение b1");
double k2 = ReadNumber("Введите значение k2");
double b2 = ReadNumber("Введите значение b2");

Console.WriteLine(GetCross(k1, k2, b1, b2));

string GetCross(double k1, double k2, double b1, double b2)
{
    double paralels = (k2 - k1);
    if(paralels == 0)
    {
        return "Прямые не пересекаются, они параллельны";
    }
    double x = (b1 - b2) / paralels;

    Console.WriteLine("x= " + x);
    double y = k1 * x + b1;
    Console.WriteLine("y= " + y);

    return string.Join("; ", new double[]{x, y});
}

int ReadNumber(string text)
{
    Console.WriteLine(text);
    int number;
    string readNumber = Console.ReadLine() ?? "Nullable";
    if (int.TryParse(readNumber, out number)) { }
    else
    {
        Console.WriteLine("Ввод некорректный. Введите только цифры!");
        number = ReadNumber(text);
    }
    return number;
}
