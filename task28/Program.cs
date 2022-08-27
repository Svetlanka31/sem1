// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон
Console.WriteLine("Введите длину стороны треугольника A: ");
double A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите длину стороны треугольника B: ");
double B = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите длину стороны треугольника C ");
double C = Convert.ToDouble(Console.ReadLine());
 if( A < B + C && C < A+B && B < A + C)
 {
    Console.WriteLine("Треугольник существует с такой длиной стороны");
 }
 else
 {
    Console.WriteLine("теугольник не существует");
 }