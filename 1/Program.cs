int[,] SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int Boundary = 0;
        if (Length1 > Boundary)
        {
            int MaxNum = array[i, Boundary];
            int MaxIndex = Boundary;
            for (int j = Boundary; j < Length1; j++)
            {
                if (array[i, j] > MaxNum) { MaxNum = array[i, j]; MaxIndex = j; }
            }
            array[i, MaxIndex] = array[i, Boundary];
            array[i, Boundary] = MaxNum;
            MaxIndex = 0;
            Boundary++;

        }
        int lastnum = array[i, Length1 - 1];
        if (lastnum > array[i, Length1 - 2]) { array[i, Length1 - 1] = array[i, Length1 - 2]; array[i, Length1 - 2] = lastnum; } //Crime against humanity
    }
    return array;
}
void DisplayArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] Array = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
SortArray(Array);
DisplayArray(Array);