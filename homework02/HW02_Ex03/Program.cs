﻿//Напишите программу, которая принимает на вход цифру, обозначающую 
//день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 6 || a == 7) Console.WriteLine("да");
else if (a < 1 || a > 7)
{
    Console.WriteLine("нет такого дня недели");
}
else Console.WriteLine("нет");

