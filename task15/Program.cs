// Задача 21. второй вариант.
Console.WriteLine("Введите координату X точки A: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y точки A: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату X точки B: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B: ");
double yB = Convert.ToDouble(Console.ReadLine());
double length = Math.Sqrt(Math.Pow( xB-xA,2) + Math.Pow(yB-yA,2) ); //Math.Sqrt - квадратный корень. 
// (Math.Pow(xB-XA),2) - Возведение в степень 2
Console.WriteLine($"Длина отрезка = {length}");