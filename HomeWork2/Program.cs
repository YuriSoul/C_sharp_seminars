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

/*Задача 13: Напишите программу, которая выводит третью цифру
заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

int number;

Console.Write("Enter a number: ");
number = Convert.ToInt32(Console.ReadLine());

while(number >= 1000)
{    
    number = number / 10; 
    
    if(number >= 100 && number < 1000)
    {
      break;
    }   
} 

if(number < 100)
{
    Console.WriteLine("There is no third number");      
} 
else 
{
    number = number % 10;
    Console.WriteLine(number);
}


/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую 
день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

int numDay;
 
Console.Write("Enter the number of the day of the week: ");
numDay = Convert.ToInt32(Console.ReadLine());

if(numDay == 6 || numDay == 7)
{
   Console.Write(numDay + "th day is off day"); 
}
else
{
   Console.Write(numDay + "th day is work day"); 
}