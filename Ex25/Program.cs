// Задача 25: Напишите цикл, который принимает на вход
//два числа (A и B) и возводит число A в натуральную
//степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

void Pow(int a, int b)
{
    int c = (int) Math.Pow(a, b);
    Console.Write($"Число {a} в степени {b} равно: {c}");
}

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Pow(a, b);


