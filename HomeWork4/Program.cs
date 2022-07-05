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
    Console.Write(sum);
}
Console.Write("Enter a number to sum its digits: ");
SumOfDigits(Convert.ToInt32(Console.ReadLine()));