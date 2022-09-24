double [,] GenerateArray(int rows, int columns, int minrnd, int maxrnd)
{
    double [,] array = new double [rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
          array[i, j] = rnd.Next(minrnd, maxrnd + 1)+
          rnd.NextDouble();  
        }
    }
    return array;
}

void PrintArray (double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

double[,] myarray = GenerateArray(4, 4, -10, 10);
PrintArray(myarray);

