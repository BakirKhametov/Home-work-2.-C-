/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.Clear();
Console.WriteLine("Введите число дня недели");
int DayNumber = int.Parse(Console.ReadLine());

if (DayNumber<=0 || DayNumber>=8)Console.WriteLine("Ошибка!Несуществующий день недели!");

if (DayNumber>=1 && DayNumber<=5)Console.WriteLine("День недели будний");

if (DayNumber==6 || DayNumber==7)Console.WriteLine("WEEEKEEEND!!!");
    