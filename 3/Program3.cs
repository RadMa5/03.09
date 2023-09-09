void Write3dMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
    }
}
int[,,] array = { { { 10, 21 }, { 55, 90 } }, { { 26, 78 }, { 85, 72 } } };
Write3dMatrix(array);