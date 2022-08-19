//Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24 
//5 -> 120

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// for ( int i=1; i <=number;i++)
// {
//     count = count *i;
 
// }
//  Console.WriteLine( count);

// 2 способ

Console.WriteLine("Enter number N:");
int number = Convert.ToInt32(Console.ReadLine());
int count =1;
for( int i = 1; i <= number; i++)
{
    count = count*i;
}
Console.WriteLine(count);
