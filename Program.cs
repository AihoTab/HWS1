//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int a;
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine()!, out a);
int coint = 1;
while (coint <= a)
{
    if (coint % 2 == 0)
        Console.Write(coint + "|");
    coint++;
}
