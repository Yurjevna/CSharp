//Задайте массив вещественных чисел. Найдите разницу между 
//максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int[] array = { 3, 7, 22, 2, 78 };
int minValue = array[0];
int maxValue = array[0];


for (int i = 0; i < array.Length; i++)
{
    if (array[i] < minValue)
    {
        minValue = array[i];
    }
    if (array[i] > maxValue)
    {
        maxValue = array[i];
    }
    
}
Console.WriteLine(minValue);
Console.WriteLine(maxValue);

int result = maxValue - minValue;
Console.WriteLine(result);