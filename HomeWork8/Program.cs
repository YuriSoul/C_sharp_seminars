/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8*/


//Метод для сортировки строк двумерного массива по убыванию
void SortRows2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int index = 0; //индекс первого элемента в столбце строки массива
        int maxIndex = 0; //предпологаем что под индексом 0 лежит элемент строки массива который является
                        // максимальным числом в строке массива
        int temp = 0; //временная переменнная которая будет служить для обмена значений между ячейками строки массива 
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            //проходим циклом по всей строке двумерного массива и по порядку сравниваем числа между собой, т.о. что крайняя правая ячейка массива
            //будет сравниваться только при первой итерации цикла а при последующих проходах она будет смещаться в лево тем самым
            //отсекая все отсортированные уже числа (ячейки)
            while (index < (array.GetLength(1)-j)){

            /*если число в array[index] (первый т.е. нулевой элемент массива) > числа в ячейке массива под индексом maxIndex
            в которой предположительно должно находиться максимальное число
            то в переменную maxIndex записывается номер индекса ячейки в которой на самом деле хранится очередное максимальное число
            и индекс массива увеличивается на 1, т.е. таким образом мы переходим к сравнению следующего элемента массива
            если условиие array[index] > числа в ячейке массива под индексом maxIndex невыполняется то число записанное
            в maxIndex не изменяется но индекс все равно увеличивается на 1, и мы переходим к сравнению следующего элемента массива*/

                if (array[i,index] > array[i,maxIndex]) maxIndex = index;
                index = index + 1;
            }

            //после того как мы определили максимальное значение в строке массива его теперь необходимо поместить в последнюю
            //ячейку строки массива но таким образом чтобы значение в ней не затерлость безвозвратно.
            //для этого будем использовать временную переменную temp

            temp = array[i,(array.GetLength(1) - 1 - j)]; //для начала сохраним в temp значение из последней ячейки строки массива
            array[i,(array.GetLength(1) - 1 - j)] = array[i,maxIndex]; //теперь запишем в последнюю ячейку наше максимальное значение из строки массива
            //а в ячейку с максимальным значением запишем число которое мы ранее сохранили в переменную temp из последней ячейки строки массива
            array[i,maxIndex] = temp;

            //после первой сортировки мы снова должны обнулить переменные index и maxIndex, чтобы снова начать сортировку с нулевого элемента
            index = 0;
            maxIndex = 0;

            //увеличиваем значение j на 1. Отсекая таким образом крайние правые отсортированные ячейки строки массива.
            
        }        
    }
}

/*Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер
строки с наименьшей суммой элементов: 1 строка*/

//Метод поиска строки двумерного массива с минимальной суммой элементов в ней 
void SearchRowWithMinSun2dArray(int[,] array)
{
    int[] sumArray = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
            
        }
        sumArray[i] = sum;                
    }
    Console.WriteLine();
    int minIndex = 0;

    for(int i = 0; i < sumArray.Length; i++)
    {   
        
        /*если условиие sumArray[i] < sumArray[minIndex] выполняется то в minIndex записывается индекс очередного минимального числа
        и индекс массива увеличивается на 1, т.е. таким образом мы переходим к сравнению следующего элемента массива
        если условиие sumArray[i] < sumArray[minIndex] невыполняется то индекс все равно увеличивается на 1, и мы переходим
        к сравнению следующего элемента массива*/

        if (sumArray[i] < sumArray[minIndex]) minIndex = i; //определяем место минимального числа в массиве        
    }
    
    Console.Write(minIndex);
    
}


/*Задача 58: Задайте две матрицы. Напишите программу,
которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49*/

//Метод выводящий
void ProductMatrices(int[,] matrix1, int[,] matrix2)
{   
    int[,] productMatrices = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            productMatrices[i,j] = matrix1[i,j]*matrix2[i,j];
            Console.Write(productMatrices[i,j] + " ");
        }
        Console.WriteLine();
    }
}


//Метод создающий двумерный массив и заполняющий его случайными числами 
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

//Метод выводящий двумерный массив на печать
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

SortRows2dArray(myArray);

Console.WriteLine();

Show2dArray(myArray);

Console.WriteLine();

SearchRowWithMinSun2dArray(myArray);

Console.WriteLine();

int[,] matrix1 = CreateRandom2dArray(row, column, 1, 9);
int[,] matrix2 = CreateRandom2dArray(row, column, 1, 9);
Show2dArray(matrix1);
Console.WriteLine();
Show2dArray(matrix2);
Console.WriteLine();
ProductMatrices(matrix1, matrix2);
Console.WriteLine();


int[,,] m = new int[2, 2, 2];
        int n = 10;
        for (int x = 0; x < 2; x++)
        {
            for (int y = 0; y < 2; y++)
            {
                for (int z = 0; z < 2; z++)
                {
                    m[x, y, z] = n++;
                    Console.Write($"{m[x, y, z]}({x},{y},{z}) ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();     
        }
        Console.ReadLine();