// Метод переворачивающий массив наоборот
int [] ReverseArray(int[] array)
{
    for (int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    return array;
}

string ConvertDecNumToBinary(int num)
{
    string convNum = string.Empty;
    while (num > 0)
    {
        convNum = num%2 + convNum;//остаток от деления исходного числа на 2 записываем в строку
        num = num/2; //исходное число делим на 2 
    }
    return convNum;
}
Console.WriteLine(ConvertDecNumToBinary(10));

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
//Задаем массив
int[] array = {1, 2, 3, 4, 5};

//Выводим массив на печать
PrintArray(array);
//Переворачиваем массив
ReverseArray(array);
//Повторно выводим перевернутый массив на печать
PrintArray(array);


