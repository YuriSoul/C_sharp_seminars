//Задача 64: Задайте значение N. Напишите программу,
//которая найдет факториал числа N рекурсивным методом.
//N = 4 -> 24
/*
int Factorial(int n)
{
    //1! = 1
    //0! = 1

    if(n == 1) return 1;
    else return (n * Factorial(n - 1));
}

    Console.WriteLine(Factorial(4));
*/
//Задача 66: Задайте значения M и N. Напишите программу,
//которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int SumSeqNumbers(int m, int n)
{
    if(m < n)
    {
       m = m + SumSeqNumbers((m+1), n);        
    }    
    return m;    
}

Console.Write(SumSeqNumbers(1, 15));