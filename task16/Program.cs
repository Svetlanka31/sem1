// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
Console.WriteLine("Введите число: ");
double number = Convert.ToDouble(Console.ReadLine());
double count = 1;
while (count <= number)
{
    Console.WriteLine(Math.Pow(count,2));
 count++;
 }


