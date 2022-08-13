// Задача 28. Вариант c array
double[]A = new double[2];
double[]B = new double[2];
Console.WriteLine("Введите координату x1: ");
A[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y1: ");
A[1] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату x2: ");
B[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y2: ");
B[1] = Convert.ToDouble(Console.ReadLine());
double length = Math.Sqrt(Math.Pow(B[0] - A[0],2) + Math.Pow(B[1] - A[1],2));
Console.WriteLine(length);