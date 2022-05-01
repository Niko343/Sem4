// Задача 27: Напишите программу, которая принимает на
//вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
void PrintSum(int a)
{
    int sum = 0;
    while(a > 0)
    {
        int b = a % 10;
        sum = sum + b;
        a = (a - b) / 10;
    }
    Console.Write(sum);
}
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
PrintSum(a);
