// Напишите программу, которая
//принимает на вход число N и выдаёт
//произведение чисел от 1 до N.
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
int Result = 1;
for(int i = 1; i <= a; i++)
{ 
    Result = Result * i;
}
Console.WriteLine(Result);
