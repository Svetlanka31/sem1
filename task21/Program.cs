//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке
// Console.Clear();

// int N = 20;
// int min = 0;
// int max = 1;
// int[] Array(int N, int min, int max)
// {
//     int[] arr = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         arr[i] = new Random().Next(min, max + 1);
//     }
//     return arr;
// }
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }
// Console.WriteLine();
// PrintArray(Array(N, min, max));
// Console.WriteLine();

// 2 способ
 Console.WriteLine("Введите размер массива: ");
 int number = Convert.ToInt32(Console.ReadLine());

int FillArray(int [] array)
 {
    int length = array.Length;
    {
        for ( int i = 0; i< array.Length; i++)
        {
            array[i] = new Random().Next(0,2);
        }
        
    }
    return number;
 }
 void PrintArray(int[] arr)
 {
    int count = arr.Length;
    for( int pos = 0; pos < arr.Length; pos++)
    {
        Console.WriteLine(arr[pos]);
    }
 }
int [] array = new  int[8];
FillArray(array);
PrintArray(array);