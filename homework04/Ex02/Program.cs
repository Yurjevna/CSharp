//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int sum(int N)
{
    int result=0;
    while(N>0)
    {
        result += N % 10;
        N=N/10;
    }
    return result;
}
int newsum=sum(9012);
Console.WriteLine(newsum);