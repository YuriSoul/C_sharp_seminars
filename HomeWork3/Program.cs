/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом
14212 -> нет
12821 -> да
23432 -> да*/


void checkPalindrome(int num)
{
    int n = num; //сохраняем заданное число во временную переменную
    int size = 0; //размер массива
    int i = 1; //счетчик массива 
    Console.Write("Число " + num + " "); //выводим заданное число


    //вычисляем количество цифр в заданном числе 
    while(n != 0)
    {
        n = n / 10;
        size++;           
    }

    //создаем массив для поразрядного сохранения числа
    int[] arr = new int[size];

    //поразрядно записываем числа в массив
    while(num != 0)
    {
        arr[size-i] = num % 10;
        num = num / 10; 
        i++;          
    }

    i = 1;
    bool pal = true;

    //поочередно сравниваем первое и последнне числа массива
    while(i-1 < size)
    {
        if(arr[i-1] == arr[size-i])
        {
            i++;        
        }    
        else
        {
            Console.WriteLine("НЕ является полиндромом");
            pal = false;
            break;
        } 
    }
    if(pal == true) Console.WriteLine("является полиндромом");
}

    Console.Write("Enter a five-digit number to check: ");
    checkPalindrome(Convert.ToInt32(Console.ReadLine()));




/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов
чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

void Exponentiation(int number)
{
    int i = 1, j = 0;
    int exp = 3; //степень числа в которую нужно возвести ряд чисел
    int cube = i;
    while(i <= number)
    {
        while(j<=(exp-1))
        {
            cube = cube * i;
            j++;
        }
        
        Console.Write(cube + " ");
        i++;
        cube = i;
        j = 1;
        
    }
    Console.WriteLine();
}

Console.Write("Enter a series of numbers to raise to a power 3: ");
Exponentiation(Convert.ToInt32(Console.ReadLine()));


/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double GetDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    //для начала найдем длины катетов
    double xLine = x2 - x1; //длина первого катета
    double yLine = y2 - y1; //длина второго катета 
    double zLine = z2 - z1; //длина вертикального катета 

    double distQuad = (xLine * xLine) + (yLine * yLine) + (zLine * zLine); //квадрат гипотинузы 3-D треугольника  
    double result = Math.Sqrt(distQuad); //длина гипотенузы 3-D треугольника
    
    return result;
}

Console.WriteLine("Введите координаты точки А: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(GetDistance(x1, y1, z1, x2, y2, z2));
