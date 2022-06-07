/*
Заполните спирально массив 4 на 4.
*/
int[,] array1 = GetArray(4, 4);
Console.WriteLine("Сформированный массив:");
PrintArray(array1);
int[,] GetArray(int a, int b)
{
    int[,] array = new int[a, b];
    int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, gran = b;

    for (int i = 0; i < array.Length; i++)
    {
        array[col, row] = i + 1;
        if (--gran == 0)
        {
            gran = b * (dirChanges % 2) + a * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }
        col += dx;
        row += dy;
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