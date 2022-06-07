/*
Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива.
*/
int[,] array = GetArray(2, 6);
Console.WriteLine("Сформированный массив:");
PrintArray(array);
ArraySort();
Console.WriteLine("Упорядоченный массив массив:");
PrintArray(array);
void ArraySort(int[,] array)
{
    int n = array.GetLength(0), m = array.GetLength(1);
    for (int c = 0; c < n; c++)
        for (int i = 0; i < m; i++)
            for (int j = 0; j < m - 1; j++)
                if (array[c, j] < array[c, j + 1])
                {
                    int temp = array[c, j];
                    array[c, j] = array[c, j + 1];
                    array[c, j + 1] = temp;
                }
}
int[,] GetArray(int a, int b)
{
    int[,] array = new int[a, b];
    Random rndNum = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rndNum.Next(10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}