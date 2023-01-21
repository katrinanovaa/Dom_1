/*Задача 21
Напишите программу, которая принимает на вход координаты двух 
точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.Clear();
Console.WriteLine("Введите координаты точки А, в порядке {x,y,z}");
int xA = int.Parse(Console.ReadLine()!);
int yA = int.Parse(Console.ReadLine()!);
int zA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты точки B, в порядке {x,y,z}");
int xB = int.Parse(Console.ReadLine()!);
int yB = int.Parse(Console.ReadLine()!);
int zB = int.Parse(Console.ReadLine()!);
double res = Math.Sqrt(Math.Pow(xB-xA,2)+Math.Pow(yB-yA,2)+Math.Pow(zB-zA,2));
Console.WriteLine($"Расстояние равно {res:f2}");
