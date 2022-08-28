//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int Metod(int b1; int k1; int b2; int k2);
{
    int x;
    int y;
    if (k1 != K2) ;
    {
        x = (b1 - b2) * (k1 - k2);
        y = k1 * ((b2 - b1) / (k1 - k2) + b1);
        return x;
        return y;
    }
    else (k1 - k2);
    {
        return 0;
    }
}
int result = Metod(2, 5, 4, 9);
Console.WriteLine(result);