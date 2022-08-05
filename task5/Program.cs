//напишите программу, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа 
Console.WriteLine("Введите трезначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = number % 10;
Console.WriteLine(i);

