/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

int a, b;

Console.Write("Input a first number: ");
a = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Input a second number: ");
b = Convert.ToInt32(Console.ReadLine());


if(a > b)
{
   Console.WriteLine("max = " + a);
}
else
{
    Console.WriteLine("max = " + b);
}


/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

int num1, num2, num3;  

//Сгенерируем 3 случайных числа от 0 до 100
num1 = new Random().Next(0, 100); //[0, 99)
num2 = new Random().Next(0, 100);
num3 = new Random().Next(0, 100);

Console.WriteLine("num1 = " + num1);
Console.WriteLine("num2 = " + num2);
Console.WriteLine("num3 = " + num3);

int max = num1;
if(num1 > max) max = num1;
if(num2 > max) max = num2;
if(num3 > max) max = num3;

Console.Write("max = " + max);


/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

int number;

Console.Write("Input a number: ");
number = Convert.ToInt32(Console.ReadLine()); 


if(number % 2 == 0)
{
   Console.WriteLine($"number {number} is even");
}
else
{
    Console.WriteLine($"number {number} is not even");
}


/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

int num;
int i = 1;

Console.Write("Input a number: ");
num = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Numbers: ");

while(i <= num)
{
    if(i % 2 == 0)
    {
        Console.Write(i + " ");
    }
    i++;
}

Console.Write("in even");