//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int a, b, c;
Console.Write("Введите первое число для сравнения: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write("Введите второе число для сравнения: ");
int.TryParse(Console.ReadLine()!, out b);
Console.Write("Введите третье число для сравнения: ");
int.TryParse(Console.ReadLine()!, out c);
int max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.WriteLine($"Наибольшее число = {max}");


/* Другой вариант
int a, b, c;
Console.Write("Введите первое число для сравнения: ");
a = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число для сравнения: ");
b = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число для сравнения: ");
c = int.Parse(Console.ReadLine()!);
if (a > b)
{
    if (a > c)
        Console.WriteLine($"Наибольшее число = {a}");
    else
        Console.WriteLine($"Наибольшее число = {c}");

}
else
{
    if (b > c)
        Console.WriteLine($"Наибольшее число = {b}");
    else
        Console.WriteLine($"Наибольшее число = {c}");
}
*/