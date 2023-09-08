int[,] SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int Boundary = 0;
        if (array.GetLength(1) >= Boundary)
        {
            int MaxNum = array[i, Boundary];
            for (int j = Boundary; j < array.GetLength(1); j++)
            {
                int MaxIndex = 0;
                if (array[i, j] > MaxNum) { array[i, j] = MaxNum; MaxIndex = j; }
            }
            array[i, MaxIndex] = array[i, Boundary];
            array[i, Boundary] = MaxNum;
            Boundary++;

        }
    }
    return array;
}
void DisplayArray(Array)
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
int[,] Array = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
SortArray(Array);
DisplayArray();