/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

while (true)
{
    Console.WriteLine("Напиши первое целочисленное число:");
    int n1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Напиши второе целочисленное число:");
    int n2 = int.Parse(Console.ReadLine()!);

    if (n1==n2)
        {
            Console.WriteLine("Введите неравные числа!");
            continue;
        }

    Console.WriteLine("Напиши третье целочисленное число:");
    int n3 = int.Parse(Console.ReadLine()!);
    if ((n3==n1)^(n3==n2))
        {
            Console.WriteLine("Введите неравные числа!");
            continue;
        }
    if ((n1>n2)&&(n1>n3))
       {
         Console.WriteLine($"Максимальное число {n1}");
            break;
       }
        else
        {
            if (n2>n3)
            {
                Console.WriteLine($"Максимальное число {n2}");
                break;
            }
                else 
                {
                    Console.WriteLine($"Максимальное число {n3}");
                    break;
                }
                break;
            }
}


