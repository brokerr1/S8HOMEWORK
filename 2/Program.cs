/*
Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов.
*/
int[,] array = GetArray(3, 8);
Console.WriteLine("Сформированный массив:");
PrintArray(array);
CalculateArraySum();
void CalculateArraySum()
{
    int str = 0;
    double abssum = double.MaxValue;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        if (sum < abssum)
        {
            abssum = sum;
            str = i+1;
        }
        Console.WriteLine("Сумма {0} строки = {1}", i + 1, sum);
        
    }
    Console.WriteLine("Строка {0} в данном массиве имеет наименьшую сумму элементов равную: {1}", str, abssum);
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