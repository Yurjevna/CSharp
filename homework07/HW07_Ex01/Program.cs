//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

double[,] CreateArray(int rows, int columns)
{
    return new double[rows, columns];
}
    int m = 3;
    int n = 4;
    double[,] arr = CreateArray(m, n);
    for (int row = 0; row < m; row++)
    {
        for (int colum = 0; colum < n; colum++)
        {
            arr[row, colum] = new Random().NextDouble();
            Console.Write($"{arr[row, colum],3}");
        }
        Console.WriteLine();
    }