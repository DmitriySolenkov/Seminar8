int[,] FillMatrix(int length1, int length2)
{
    int[,] array = new int[length1, length2];
    for (int i = 0; i < length1; i++)
    {
        for (int j = 0; j < length2; j++)
        {
            array[i, j] = new Random().Next(0, 11);
        }
    }
    return array;
}

int Prompt(string message)
{
    Console.Write(message);
    int res = Convert.ToInt32(Console.ReadLine());
    return res;
}

void PrintMatrix(int[,] matrix)
{
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            Console.Write($"{matrix[k, l]}\t");
        }
        Console.WriteLine();
    }
}


int line = Prompt("Введите число строк: ");
int column = Prompt("Введите число колонок: ");
if (line > 0 && column > 0)
{
    int[,] matrix = FillMatrix(line, column);
    PrintMatrix(matrix);
    Console.WriteLine();
    int[] buffer = new int[matrix.GetLength(1)];
    for (int n = 0; n < matrix.GetLength(1); n++)
    {
        buffer[n] = matrix[0, n];
        matrix[0, n] = matrix[matrix.GetLength(0) - 1, n];
        matrix[matrix.GetLength(0) - 1, n] = buffer[n];
    }

    PrintMatrix(matrix);

}
else
{
    Console.WriteLine("Неверные значения!");
}