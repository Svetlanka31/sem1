//Задача 39. Напишите прорамму, которая перевернет одномерный массив (последний элемент будет на первом,
// первый на последнем)
//[1 2 3 4 5] -> [5 4 3 2 1]

const  int ARRAY_SIZE = 6;
const int LEFT_RANGE =-10;
const int RIGTH_RANGE = 10;

int [] FillArray(int size,  int leftRange,int rigthRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange,rigthRange +1);
    }
    return arr;
}
void ReverseArray( int[] arr)
{
    int temp = 0;
    for( int i = 0; i < arr.Length/2; i++)
    {
        temp = arr[i];
        arr[i] = arr[arr.Length -1-i];
        arr[arr.Length -1-i] = temp;
    }
}
int [] array = FillArray(ARRAY_SIZE,LEFT_RANGE,RIGTH_RANGE);
Console.WriteLine('[' + string.Join(", ", array) +']');
ReverseArray(array);
Console.WriteLine('[' + string.Join(", ", array) +']');