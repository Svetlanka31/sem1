﻿// See https://aka.ms/new-console-template for more information
int[]point = new int[2];
Console.WriteLine("Введите координату x: ");
point[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y: ");
point[1] = Convert.ToInt32(Console.ReadLine());
if (point[0] > 0 && point[1] > 0)
{
    Console.WriteLine("Первая четверть");
}
 else if (point[0] < 0 && point[1] > 0)
{
    Console.WriteLine("Вторая четверть");
}
 else if (point[0] < 0 && point[1] < 0)
{
    Console.WriteLine("Третья четверть");
}
else if (point[0] > 0 && point[1] < 0)
{
    Console.WriteLine("Четвертая четверть");
}
else  
{
    Console.WriteLine("Точка лежит на оси");
}