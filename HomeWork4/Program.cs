/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/


void SumOfDigits(int num)
{
    int size = 0; //размер массива
    int i = 1; //счетчик массива 
    int sum = 0; //переменная для хранения суммы цифр в заданном числе
    int n = num; //сохраняем заданное число во временную переменную
    
    //вычисляем количество цифр в заданном числе 
    while(n != 0)
    {
        n = n / 10;
        size++;           
    }

    //создаем массив для поразрядного сохранения цифр числа
    int[] arr = new int[size];

    //поразрядно записываем числа в массив
    while(num != 0)
    {
        arr[size-i] = num % 10;
        num = num / 10; 
        i++;          
    }

    for (i = 0; i < arr.Length; i++)
    {
        sum = sum + arr[i];
    }

    Console.Write("The sum of the digits in a number: "); //выводим заданное число
    Console.WriteLine(sum);
}
Console.Write("Enter a number to sum its digits: ");
SumOfDigits(Convert.ToInt32(Console.ReadLine()));


/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и
выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

//создаем массив из 8-и элементов

//Метод заполняющая массив числами 
void FillArray(int[]array)
{
    
    //Цикл для заполнения массива случайными цислами 
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
        i++;
    }
}

//Метод выводящий массив на печать
void PrintArray(int[]array)
{
    //Цикл для печати массива
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");        
    }
}

//Создаем пустой массив из 8-и элементов
int[] array = new int[8];

//Наполняем массив числами
FillArray(array);

Console.Write("Source array: ");

//Выводим массив на печать
PrintArray(array);
