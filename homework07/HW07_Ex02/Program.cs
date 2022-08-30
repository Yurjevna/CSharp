//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1, 7 -> такого числа в массиве нет

//инициализация массива
int[,] CreateArray(int rows, int columns)
{
    return new int[rows, columns];
}
int m = 3;
int n = 4;
int[,] arr = CreateArray(m, n);
for (int row = 0; row < m; row++)
{
    for (int colum = 0; colum < n; colum++)
    {
        arr[row, colum] = new Random().Next(1, 10);
        Console.Write($"{arr[row, colum],3}");
    }
    Console.WriteLine();
}
int b= arr[2,2];
Console.WriteLine(b);

