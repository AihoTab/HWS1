//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int a, b;
Console.Write("Введите первое число для сравнения: ");
a = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число для сравнения: ");
b = int.Parse(Console.ReadLine()!);
if (a > b)
{
    Console.WriteLine($"Наибольшее число = {a}");
}
else
{
    Console.WriteLine($"Наибольшее число = {b}");
}
