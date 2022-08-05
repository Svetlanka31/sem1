// Напишите программу, которая на входе принимает два числа и проверяет, является ли первое квадратом второго
Console.WriteLine("Введите первое число: ");
int numberone = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numbertwo = Convert.ToInt32(Console.ReadLine());
if (numberone == numbertwo * numbertwo) {
    Console.WriteLine("Верно");
} else {
    Console.WriteLine(" неверно");
}