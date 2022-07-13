/*Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

int sizeArray, countNum;

Console.WriteLine("Specify the number of numbers to enter: ");

sizeArray = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Enter {sizeArray} numbers:");

countNum = CountPosNumInArray(sizeArray);

Console.WriteLine("Number of positive numbers: " + countNum);
//Метод подсчитывающий количество положительных 
int CountPosNumInArray(int sizeArray)
{
    int count = 0;
    int[] array = new int[sizeArray];
    
    //Цикл для заполнения массива числами 
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine()); 
        if(array[i] > 0) count++;       
    }
    return count;
}


/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)*/

double k1 = 5, k2 = 9, b1 = 2, b2 = 4;

FindPointIntersectionOfLines(k1, k2, b1, b2);

void FindPointIntersectionOfLines(double k1, double k2, double b1, double b2)
{
    double x, y;
    x = (b2 - b1)/(k1 - k2);
    y = x * k2 + b2;

    Console.WriteLine(x);
    Console.WriteLine(y);
}
