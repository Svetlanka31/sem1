// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Console.WriteLine("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int i = 0;
// int b =a;
// while( a >0)
// {
//     i+=1;
//     a= a /2;
// }
// int []array = new int[i];
// for(int count = 0; count<i; count++)
// {
//     array[count] = b % 2;
//     b= b / 2;

// }
// void ReverseArray(int[] arr)
// {
//     int temp =0;
//     for (int count = 0; count< i/2; count++)
//     {
//         temp = arr[count];
//         arr[count] = arr[i - 1- count];
//         arr[i - 1- count] = temp;
//     }
// }
// ReverseArray(array);
// Console.WriteLine(string.Join(" ", array));

//  Console.WriteLine("Введите число: ");
//  int a = Convert.ToInt32(Console.ReadLine());
//  string result = string.Empty;
//  while(a!=0)
//  {
//     result += Convert.ToString(a%2);
//     a= a/2;
//  }
//  Console.WriteLine(result);
 // еще нужно перевернуть

 //решение с помощью рекурсии

void PrintBinary(int N)
{
   if(N<=0) return;
   PrintBinary(N/2);
   Console.WriteLine(N%2);
}
 Console.WriteLine("Введите число: ");
 int number = Convert.ToInt32(Console.ReadLine());
 PrintBinary(number);
