﻿//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] array = new int [4];
for (int i = 0; i < array.Length; i++)
{
array[i]= new Random().Next(1,20);
Console.WriteLine("Значение элемента массива " + i +  " = "  + array[i]);
}
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 !=0)
    {
        
        sum =sum + array[i];
    }
}
Console.Write("Сумма нечетных элементов массива ");
Console.Write(sum);







    
