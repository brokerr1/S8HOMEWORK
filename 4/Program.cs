/*
Сформируйте трёхмерный массив из неповторяющихся
двузначных чисел. Напишите программу, которая будет построчно выводить
массив, добавляя индексы каждого элемента.
*/
int[,] array = GetArray(3, 3);
int[,] array1 = NewArray(array);
Console.WriteLine("Сформированный массив:");
PrintArray(array1);
bool FindNumer(int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                return true;
            }
        }
    }
    return false;
}
int[,] GetArray(int a, int b)
{
    int[,] array = new int[a, b];
    Random rndNum = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rndNum.Next(10,100);
        }
    }
    return array;
}
int[,] NewArray(int[,] array)
{
    Random rndNum = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int numberRnd = 0;
            do
            {
                numberRnd = rndNum.Next(10, 100);
                array[i, j] = numberRnd;
            } while (FindNumer(numberRnd) == false);
            
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