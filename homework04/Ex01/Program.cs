// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Step(int A, int B)
{
    int n= A;
    for(int i=1; i<B; i++)
    {
        n=n*A;
    }
    return n;
}
int result=Step(3,5);
Console.WriteLine(result);