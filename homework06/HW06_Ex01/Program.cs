//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int []array = new int [5];
for(int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i}: ");
    array[i]= int.Parse(Console.ReadLine());
}
int count = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i]>0)
    {
     count=count+1;
    }
}
Console.WriteLine("Количество положительных элементов массива: ");
Console.Write(count);