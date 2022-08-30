//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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

double Average(int[,]arr)
{   double columAverage=0;
    for(int colum=0; colum< arr.GetLength(1);colum ++)
    {
        double columSum=0;
                for(int row=0; row < arr.GetLength(0); row ++)
        {
            columSum = columSum + arr[row,colum];
        }
        columAverage = Math.Round(columSum/arr.GetLength(1),2);
        Console.WriteLine(columAverage);
    }
    return columAverage;
}
Average(CreateArray(3,4));

       