//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int m = 3;
int n = 4;
int[,] array = new int[m, n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    array [i, j] = Convert.ToInt32(new Random().Next(0,21));
}
Console.WriteLine();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    Console.Write(array[i,j] + "\t ");
    Console.WriteLine();
}
Console.WriteLine();
 
int SumLineEl (int[,] array, int i)
{
    int SumLine = array [i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        SumLine += array[i, j];
    }
    return SumLine;
}
 
int MinSumLines = SumLineEl(array, 0);
int CurSumeLine = 0;
int IndMinSumLine = 0;
for(int i = 1; i < array.GetLength(0); i++)
{
    CurSumeLine = SumLineEl(array, i);
    if(CurSumeLine < MinSumLines)
    {
        MinSumLines = CurSumeLine;
        IndMinSumLine = i;
    }
}
 
Console.Write("Индекс строки с наименьшей суммой элементов: ");
Console.WriteLine(IndMinSumLine);
 