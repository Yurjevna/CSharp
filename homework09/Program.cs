int Over (int M, int N)
{
    int sum = 0;
if (M>N)
    for (int i = N; i <= M; i++)
    sum = sum + i;
    else
        for (int i = M; i <= N; i++)
        sum = sum + i;
        return sum;
}
int result = Over (2,8);
Console.Write ("Итого сумма чисел составляет: ");
Console.WriteLine(result);
