
/*Задача 47. Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

//Метод генерирующий двумерный массив вещественных чисел
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

//Задаем размерность двумерного массива
Console.Write("Input row: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Input column: ");
int column = Convert.ToInt32(Console.ReadLine());

//Генерируем двумерны вещественный массив
double[,] myArray = CreateRandomDoubleArray(row, column, 1, 9);
//Выводим массив в консоль
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
    Console.Write(string.Format("At this position in the array is a number: {0:f1}", array[posInRow-1, posInColumn-1]));

    else Console.WriteLine("There is no such element in the array.");
}

//Принимаем данные от пользователя (запрашиваем позицию элемента для проверки)
Console.WriteLine("Enter the position of the element in the array to check.");

Console.Write("Row number: ");
int posInRow = Convert.ToInt32(Console.ReadLine());

Console.Write("Column number: ");

int posInColumn = Convert.ToInt32(Console.ReadLine());

//Выводим сгенерированный массив в консоль
Show2dArray(myArray);

Console.WriteLine();

//Выводим результат в консоль
CheckPoseElementArray(myArray, posInRow, posInColumn);
Console.WriteLine();


/*Задача 52. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

//Метод вычисляющий среднее арифметическое каждого из столбцов в массиве
void AverageElemeColumnsInArray(int[,] array)
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

//Метод создающий двумерный массив и заполняющий его случайными целыми числами 
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

////Выводим результат в консоль
AverageElemeColumnsInArray(CreateRandom2dArray(row, column, 1, 9));