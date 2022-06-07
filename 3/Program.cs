/*
Задайте две матрицы. Напишите программу, которая будет
*находить произведение двух матриц.
*/
int[,] array1 = GetArray(3, 3);
Console.WriteLine("Сформированный первый массив:");
PrintArray(array1);
int[,] array2 = GetArray(3, 3);
Console.WriteLine("Сформированный второй массив:");
PrintArray(array2);
Console.WriteLine("Произведение двух массивов:");
Matrix();
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
void Matrix()
{
    int j;
    for (int i = 0; i < 3; i++)
    {
        for (j = 0; j < 3; j++)
        {
            array1[i, j] = array1[i, j] * array2[i, j];
            Console.Write($"{array1[i, j]} ");
        }
        j = 0;
        Console.WriteLine();
    }
}