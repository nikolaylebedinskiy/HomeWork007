int[,] GenerateArray(int rows, int columns, int minrnd, int maxrnd)
{
    int[,] array = new int[rows, columns];
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

void PrintArray(int[,] matrix)
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

int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

(int, bool) IndexValue(int[,] array, int row, int column)
{
    if (0 <= row && row < array.GetLength(0) && 0 <= column && column < array.GetLength(1))
    {
        return (array[row, column], true);
    }
    else
    {
        return (0, false);
    }
}

int[,] NewArray = GenerateArray(5, 5, -100, 100);
PrintArray(NewArray);
int row = Prompt("Введите номер строки массива: ");
int column = Prompt("Введите номер столбца массива: ");
(int result, bool isEx) = IndexValue(NewArray, row, column);
if (isEx)
{
    System.Console.WriteLine($"Элемент массива равен: {result}");
}
else
{
    System.Console.WriteLine("Такого элемента в массиве нет");
}
