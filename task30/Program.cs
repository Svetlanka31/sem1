// Задача 46. Задайте двумерный массив размером m*n, заполненный случайными целыми числами.
Console.WriteLine("ВВедите двумерный массив mхn:");
Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m,n];
for (int i = 0; i < m; i++)
{
   for (int j = 0; j < n; j++)
   {
    matrix[i,j] = new Random().Next(-100,101);
    Console.Write(matrix[i,j] +" ");
   } 
   Console.WriteLine();
} 