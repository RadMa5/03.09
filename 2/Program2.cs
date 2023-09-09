void SmallestRow(int[,] matrix)
{
    int SmallestR = 0;
    int SmallestNum = 9999999;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int SmallestNumC = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            SmallestNumC += matrix[i, j];
        }
        if (SmallestNumC < SmallestNum) { SmallestNum = SmallestNumC; SmallestR = i; }
    }
    Console.WriteLine($"{SmallestR + 1} row is the smallest");
}
int[,] array = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } , { 5, 2, 6, 7 } };
int[,] array2 = { { 5, 9, 2, 3 }, { 8, 4, 2, 4 }, { 1, 4, 7, 2 }, { 5, 2, 6, 7 } };
SmallestRow(array);
SmallestRow(array2);