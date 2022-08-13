//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D
Console.WriteLine("Введите координату X точки A: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y точки A: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату X точки B: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B: ");
double yB = Convert.ToDouble(Console.ReadLine());
double length = Math.Sqrt((xA - xB)*(xA - xB)+(yA - yB)*(yA - yB));
Console.WriteLine($"length = {length}");

