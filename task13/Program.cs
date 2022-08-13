// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
// second variant
Console.WriteLine("Введите номер четверти");
int quater = Convert.ToInt32(Console.ReadLine());
string[] arr = {"x > 0, Y > 0","x < 0, Y > 0", "x < 0, Y < 0", "x > 0, Y < 0"};
if (quater >=1 && quater<=4)
{
    Console.WriteLine(arr[quater-1]);
}
else
{
    Console.WriteLine("Такой четверти нет");
}
