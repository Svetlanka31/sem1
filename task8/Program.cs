// Напишите программу, которая будет на вход принимать два числа и выводить, является второе число кратным первомуюЕсли число2 не кратно первому, то программа выводит остаток от деления 
Console.WriteLine("ВВедите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1%number2==0)
{
    Console.WriteLine($"{number2} kратно {number1}");
}
else
{
    Console.WriteLine(number1%number2);
}
