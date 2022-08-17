// Напишите программу, которая принимает число А и выдает сумму чисел от 1 до А
Console.WriteLine("Введите число A: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 1; i<= number; i++)
{
    sum = sum + i;
}
Console.WriteLine($"Результата работы программы = {sum}");