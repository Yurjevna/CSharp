//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] array = new int[8];
for(int i=0; i<array.Length; i++)
{
  Console.Write($"Введите элемент массива под индексом {i}:\t");
  array[i]=int.Parse(Console.ReadLine());
}
Console.WriteLine ("Вывод массива: ");
for(int i=0; i<array.Length; i++)
{
  Console.Write(array[i]);
}