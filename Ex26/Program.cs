// Программа принимает на вход число и выдаёт количество цифр в числе
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
int b = 1;
while(a > 10)
{
    a = a / 10;
    b++;
}
Console.Write(b);