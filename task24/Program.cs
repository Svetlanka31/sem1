//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9,9].
//Найдите сумму отрицательных и положительных элементов массива
// int [] array = new int[12];
// int sumPositiv = 0;
// int sumNegativ = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-9,10);
// }
// Console.WriteLine("[" + string.Join(", ", array) +"]");

// for (int i = 0; i < array.Length; i++)
//  {
//     if( array[i]>0)
//     {
//         sumPositiv+=array[i];
//     }
//     else
//     {
//         sumNegativ+=array[i];
//     }
//  }
//  Console.WriteLine($"Сумма положительных элементов массива = {sumPositiv}, сумма отрицательных элементов массива = {sumNegativ}");

int []FillArray (int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int [] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(leftRange,rightRange + 1);
}
return arr;
}
void sumPositivAndSumNegativ (int []arr, out int sumPositiv, out int sumNegativ)
{
    sumPositiv = 0;
    sumNegativ = 0; 
    for (int i = 0; i < arr.Length; i++)
 {
    if( arr[i]>0)
    {
        sumPositiv+=arr[i];
    }
    else
    {
        sumNegativ+=arr[i];
    }
 }
}
int [] array = FillArray(12,-9,9);
sumPositivAndSumNegativ (array, out int sumPositiv, out int sumNegativ);
Console.WriteLine("[" + string.Join(", ", array) +"]");
Console.WriteLine($"Сумма положительных элементов массива = {sumPositiv}, сумма отрицательных элементов массива = {sumNegativ}");
