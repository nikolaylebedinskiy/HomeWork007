int [,] GenerateArray(int rows, int columns, int minrnd, int maxrnd)
{
    int [,] array = new int [rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
          array[i, j] = rnd.Next(minrnd, maxrnd + 1);  
        }
    }
    return array;
}

void PrintArrayMatrix (int[,] matrix)
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

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine($"{arr[i]:f2}\t");
    }
    System.Console.WriteLine();

}
double[] ArithmeticMeanColumn(int[,] array)
{
    double sum = 0;
    double[] arColumn = new double [array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum +=array[i, j];
        }
        arColumn[i] = sum / array.GetLength(0);
        sum = 0;
    }
    return arColumn;
}

int[,] myArray = GenerateArray(3, 3, 0, 10);
PrintArrayMatrix(myArray);
double[] resultArray = ArithmeticMeanColumn(myArray);
System.Console.WriteLine("Среднее арифметическое каждого столбца: ");
PrintArray (resultArray);