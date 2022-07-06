/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными
числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int CheckEvenNum(int[]array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 == 0) count++; 
    }
    return count;
}

/*Задача 36: Задайте массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int SumOddPosArray(int[] array)
{   
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if((i+1)%2 != 0) sum += array[i];  
    }
    return sum;
}

/*Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

int DiffMaxMinNumArray(int[] array)
{   
    int max = array[0];
    int min = array[0];
    int diff = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
        if(array[i] < min) min = array[i];
    }
    diff = max - min;
    return diff;
}

//Метод заполняющая массив числами 
int[] CreateRendomArray(int size, int min, int max)
{
    int[] array = new int[size];
    //Цикл для заполнения массива случайными цислами 
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);        
    }
    return array;
}

//Метод выводящий массив на печать
void PrintArray(int[]array)
{
    //Цикл для печати массива
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");        
    }
    Console.WriteLine();
}

Console.Write("Source array: ");

//создаем массив из случайных чисел
int[] myArray = CreateRendomArray(5, 100, 999);

//Выводим массив на печать
PrintArray(myArray);

//Выводим количество четных элементов в массиве
Console.WriteLine("The number of even elements in the array: " + CheckEvenNum(myArray));

Console.WriteLine("The sum of the numbers of odd array elements is: " + SumOddPosArray(myArray));

Console.WriteLine("The difference between the maximum and minimum elements in the array is: " + DiffMaxMinNumArray(myArray));
