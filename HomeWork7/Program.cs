
/*Задача 47. Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

double[,] CreateRandomDoubleArray(int row, int column, int begin, int end)
{
    double[,] newArray = new double[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            newArray[i, j] = new Random().NextDouble()*(end - begin) + begin;
            
        }
    }
    return newArray;
}


void Show2dArray(double[,] array)
{
    double num = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            num = array[i,j]; 
            Console.Write(string.Format("{0:f1}", num) + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Input row: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Input column: ");
int column = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandomDoubleArray(row, column, 1, 9);
Show2dArray(myArray);

/*Задача 50. Напишите программу, которая на вход принимает позиции элемента
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

1 7 -> такого числа в массиве нет
*/


//Метод проверяющий наличие элемента в массиве
void CheckPoseElementArray(double[,]array, int posInRow, int posInColumn)
{
    if(posInRow-1 < array.GetLength(0) && posInColumn-1 < array.GetLength(1)) 
    Console.Write(string.Format("{0:f1}", array[posInRow-1, posInColumn-1]));

    else Console.WriteLine("There is no such element in the array.");
}

Console.WriteLine("Enter the position of the element in the array to check.");

Console.WriteLine("Row number: ");
int posInRow = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Column number: ");
int posInColumn = Convert.ToInt32(Console.ReadLine());

CheckPoseElementArray(myArray, posInRow, posInColumn);

/*Задача 52. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

void AverageElemeColumnsInArray(double[,] array)
{   
    double value = array.GetLength(0); //количество элементов в столбце 
    double sum, avr;
    
    Console.Write("Average of columns in array: ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i,j];
        }
        avr = sum/value;
        Console.Write(string.Format("{0:f2}", avr) + " ");
        
    }
}

AverageElemeColumnsInArray(myArray);