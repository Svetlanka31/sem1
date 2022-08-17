//// Напишите программу, которая принимает число А и выдает сумму чисел от 1 до А
//Решение с помощью метода

int cycle(int a)
{
    int sum = 0;
    for(int i= 1; i<=a; i++ )
    {
       sum = sum + i; 
    }
    return sum;
}
Console.WriteLine("Введите число А: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = cycle(number);
Console.WriteLine($"Текущий рзультат: {sum} ");
