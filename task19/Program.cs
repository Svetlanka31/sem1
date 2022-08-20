// Напишите программу, которая принимает на вход число и выдает количество цифр в числе
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// string number1 = Convert.ToString(number);
// number = Math.Abs(number);
// Console.WriteLine($"Колличество цифр в числе- {number1.Length}");

// 2 Способ
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int i =0;
// while (number > 0)
// {
//    number = number/10;
//   i++;
// }
// Console.WriteLine($"Колличество цифр в числе {i}");

// 3 способ с помощью функции

Console.WriteLine("Введите число: ");

int Cycle(int number)
{
int i=0;
while(number > 0){
number = number/10;
i++;
}
return number;
}

int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Cycle(number));
