
int[,] CreateRandom2dArray(int row, int column, int minValue, int maxValue)
{
    int[,] newArray = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return newArray;
}


void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}



Console.Write("Input row: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Input column: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(row, column, 1, 9);
Show2dArray(myArray);

Console.WriteLine();



