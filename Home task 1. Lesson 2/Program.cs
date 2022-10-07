// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
//782 -> 8          && number < -99 && number > -1000
//918 -> 1

Console.Clear();
Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine());

if (number > 99 && number < 1000) 
{
    int number2 = number/10 %10;
    Console.WriteLine($"Число {number2} является второй цифрой");return;
}

if (number < -99 && number > -1000) 
{
    int number2 = (number/10 %10)* -1;
    Console.WriteLine($"Число {number2} является второй цифрой");return;
}

else
{
    Console.WriteLine($"Число {number} не является трехзначным числом. Введите число соответствующее условиям задачи");
}