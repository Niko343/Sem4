// Задача 29: Напишите программу, которая задаёт массив
//из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2,
void FillArray(int[]array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}
void PrintArray(int[]array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}
int[]mass = new int[8];
 FillArray(mass);
 PrintArray(mass);
