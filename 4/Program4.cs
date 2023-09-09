string[,] LazySpiral()
{
    string[,] matrix = new string[4, 4];
    matrix[0, 0] = "01";
    matrix[0, 1] = "02";
    matrix[0, 2] = "03";
    matrix[0, 3] = "04";
    matrix[1, 3] = "05";
    matrix[2, 3] = "06";
    matrix[3, 3] = "07";
    matrix[3, 2] = "08";
    matrix[3, 1] = "09";
    matrix[3, 0] = "10";
    matrix[2, 0] = "11";
    matrix[1, 0] = "12";
    matrix[1, 1] = "13";
    matrix[1, 2] = "14";
    matrix[2, 2] = "15";
    matrix[2, 1] = "16";
    return matrix;
}
void DisplayArray(string[,] Array)
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

DisplayArray(LazySpiral());