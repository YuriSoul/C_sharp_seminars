/*Задача 10: Напишите программу, которая принимает на
вход трёхзначное число и на выходе показывает вторую
цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

int num;

Console.Write("Enter a three-digit number: ");
num = Convert.ToInt32(Console.ReadLine());

num = num / 10; //отсекаем крайнюю правую цифру числа, а оставшиеся две первых цифры 
//сохраняем в num
num = num % 10; //из оставшихся двух цифер отделяем крайнюю правую и выводим на печать 

Console.WriteLine(num + " ");



//Метод заполняющая массив числами 
/*void FillArray(int[]collection)
{
    int length = collection.Length; //Получаем длину массива
    int index = 0; //Устанавливаем позицию индекса массива в начало

    //Цикл для заполнения массива случайными цислами от 1 до 9
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

//Метод выводящий заполненный массив на печать
void PrintArray(int[] coll)
{
    int count = coll.Length;
    int position = 0;

    while (position < count)
    {
        Console.Write(coll[position]);
        position++;
    }
} 

//Массив для хранения цифр трехзначного числа
int[] array = new int[3];

FillArray(array);
PrintArray(array);
Console.WriteLine();

Console.Write(array[1]);
*/

/*Задача 2: Напишите программу, которая выводит
случайное трёхзначное число и удаляет вторую цифру
этого числа.
456 -> 46
782 -> 72
918 -> 98*/

//Метод заполняющая массив числами 
/*void FillArray(int[]collection)
{
    int length = collection.Length; //Получаем длину массива
    int index = 0; //Устанавливаем позицию индекса массива в начало

    //Цикл для заполнения массива случайными цислами от 1 до 9
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

//Метод выводящий заполненный массив на печать
void PrintArray(int[] coll)
{
    int count = coll.Length;
    int position = 0;

    while (position < count)
    {
        Console.Write(coll[position]);
        position++;
    }
} 

//Массив для хранения цифр трехзначного числа
int[] array = new int[3];

FillArray(array);
PrintArray(array);
Console.WriteLine();

Console.Write(array[0]);
Console.Write(array[2]);
*/
/*Задача 13: Напишите программу, которая выводит третью
цифру заданного числа или сообщает, что третьей цифры
нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

int number;
 
Console.Write("Enter a three-digit number: ");
number = Convert.ToInt32(Console.ReadLine());

number = number / 10; //отсекаем крайнюю правую цифру числа, а оставшиеся две первых цифры 
//сохраняем в num
number = number % 10; //из оставшихся двух цифер отделяем крайнюю правую и выводим на печать 

Console.WriteLine(num + " ");


/*
int num = 456;
int n = num;
int count = 0;
int i = 1;
Console.WriteLine(num + " ");
while(n != 0)
{
    n = n / 10;
    count++;

    /*if(count >= 3)
    {
        num = num % 1000;
        Console.Write(num);
        break;
    }*/
/*}

int[] array = new int[count];

while(num != 0)
{
    array[count-i] = num % 10;
    num = num / 10; 
    i++;  
        
}
Console.Write(array[2]);
*/




